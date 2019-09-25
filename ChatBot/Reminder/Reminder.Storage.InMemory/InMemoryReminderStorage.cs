using Reminder.Storage.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder.Storage.InMemory
{
	public class InMemoryReminderStorage : IReminderStorage
	{
		private Dictionary<Guid, ReminderItem> _reminders;

		public void Add(ReminderItem reminderItem)
		{
			_reminders.Add(reminderItem.Id, reminderItem);
		}

		public ReminderItem Get(Guid id)
		{
			return _reminders.ContainsKey(id)
				? _reminders[id]
				: null;
		}

		public List<ReminderItem> Get(ReminderItemStatus status)
		{
			return _reminders
				.Values
				.Where(
				(ReminderItem ri) => ri.Status == status)
				.ToList();
		}

		public void Update(Guid id, ReminderItemStatus status)
		{
			if (_reminders.ContainsKey(id))
				_reminders[id].Status = status;
			//else not implemented
		}
	}
}
