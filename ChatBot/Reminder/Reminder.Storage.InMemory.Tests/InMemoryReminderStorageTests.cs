using Reminder.Storage.InMemory;
using Reminder.Storage.Core;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reminder.Storage.InMemory.Tests
{
	[TestClass]
	public class InMemoryReminderStorageTests
	{
		[TestMethod]
		public void Method_Add_Should_Add_New_Item_To_Iternal_Dictionary()
		{
			//prepare date
			DateTimeOffset date = DateTimeOffset.Parse("2019-01-01T00:00:00");
			const string contactId = "ABCD123";
			const string message = "test message";

			var item = new ReminderItem(date, message, contactId);
			var storage = new InMemoryReminderStorage();

			//do test
			storage.Add(item);

			//check result
			Assert.IsTrue(storage.Reminders.ContainsKey(item.Id));
			Assert.AreEqual(message, storage.Reminders[item.Id].Message);
			Assert.AreEqual(date, storage.Reminders[item.Id].Date);
			Assert.AreEqual(contactId, storage.Reminders[item.Id].ContactId);
		}
	}
}
