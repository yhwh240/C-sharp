﻿using System;

namespace Reminder.Storage.Core
{
	public class ReminderItem
	{
		public Guid Id { get; }

		public DateTimeOffset Date { get; set; }

		public string Message { get; set; }

		public string ContactId { get; set; }

		public ReminderItemStatus Status { get; set; }

		public TimeSpan TimeToAlarm => Date - DateTimeOffset.Now;

		public bool IsReadyToSent => DateTimeOffset.Now > Date;

		public ReminderItem(DateTimeOffset date, string message, string contactId)
		{
			Id = Guid.NewGuid();
			Date = date;
			Message = message;
			ContactId = contactId;
			Status = ReminderItemStatus.Awaiting;
		}
	}
}
