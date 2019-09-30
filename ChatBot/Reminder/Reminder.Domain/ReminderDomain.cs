using System;
using System.Threading;
using Reminder.Domain.Models;
using Reminder.Storage.Core;

namespace Reminder.Domain
{
	public class ReminderDomain: IDisposable
	{
		private IReminderStorage _storage;

		private TimeSpan _awaitingRemindersCheckingPeriod;
		private TimeSpan _readyRemindersSendingPeriod;

		private Timer _awaitingRemindersChekingTimer;
		private Timer _readyReminderSendingTimer;

		public Action<ReminderItem> SendReminder { get; set; }

		public event EventHandler<SendingSucceedEventArgs> SendingSucceeded;
		public event EventHandler<SendingFailedEventArgs> SendingFailed;

		public ReminderDomain(
			IReminderStorage storage,
			TimeSpan awaitingReminderChekingPeriod,
			TimeSpan readyRemindersSendingPeriod)
		{
			_storage = storage;
			_awaitingRemindersCheckingPeriod = awaitingReminderChekingPeriod;
			_readyRemindersSendingPeriod = readyRemindersSendingPeriod;
		}

		public ReminderDomain(IReminderStorage storage)
			: this(storage, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1))
		{
		}

		public void Run()
		{
			_awaitingRemindersChekingTimer = new Timer(
				CheckAwaitingReminders,
				null,
				TimeSpan.Zero,
				_awaitingRemindersCheckingPeriod);

			_readyReminderSendingTimer = new Timer(
				SendReadyReminders,
				null,
				TimeSpan.FromSeconds(1),
				_readyRemindersSendingPeriod);
		}

		private void CheckAwaitingReminders(object state)
		{
			//здесь будет происходить проверка данных на предмет готовности к отправлению и менять их статус на ready и сохранять 

			var awaitingReminders = _storage.Get(ReminderItemStatus.Awaiting);
			foreach (var awaitingReminder in awaitingReminders)
			{
				if (awaitingReminder.IsReadyToSent)
				{
					_storage.Update(awaitingReminder.Id, ReminderItemStatus.Ready);
				}
			}
		}

		private void SendReadyReminders(object state)
		{
			//find ready reminders
			//try send 
			//if succes update status to sent
			//else update status to Failed

			var readyReminders = _storage.Get(ReminderItemStatus.Ready);
			foreach (var readyReminder in readyReminders)
			{
				try
				{
					//try "send"
					SendReminder(readyReminder);

					//update status
					_storage.Update(readyReminder.Id, ReminderItemStatus.Sent);
					//event
					SendingSucceeded?.Invoke(
						this,
						new SendingSucceedEventArgs
						{
							SendingItem = readyReminder
						});
				}
				catch (Exception e)
				{
					//failed
					_storage.Update(readyReminder.Id, ReminderItemStatus.Failed);
					//event
					SendingFailed?.Invoke(
						this,
						new SendingFailedEventArgs
						{
							SendingItem = readyReminder,
							SendingException = e
						});
				}
			}
		}
		public void Dispose()
		{
			_awaitingRemindersChekingTimer?.Dispose();
			_readyReminderSendingTimer?.Dispose();
		}
	}
}
