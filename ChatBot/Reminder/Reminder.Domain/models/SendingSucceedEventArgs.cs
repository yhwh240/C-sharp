using Reminder.Storage.Core;
using System;

namespace Reminder.Domain.Models
{
	public class SendingSucceedEventArgs: EventArgs
	{
		public ReminderItem SendingItem { get; set; }
	}
}