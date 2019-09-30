using Reminder.Domain;
using Reminder.Storage.InMemory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using System;
using System.Threading;

namespace Reminder.Domain.Tests
{
	[TestClass]
	public class ReminderDomainTest
	{
		[TestMethod]
		public void Method_Run_Should_Update_Ready_To_Send_Reminders_To_Status_Ready_From_Awaiting()
		{
			//prepare date
			var storage = new InMemoryReminderStorage();
			storage.Add(new ReminderItem(DateTimeOffset.Now, null, null));
			using (var domain = new ReminderDomain(
				storage,
				TimeSpan.FromMilliseconds(50),
				TimeSpan.FromSeconds(1)))
			{

				//do test
				domain.Run();
				Thread.Sleep(200);
			}
			//check result
			var readyList = storage.Get(ReminderItemStatus.Ready);
			Assert.IsNotNull(readyList);
			Assert.AreEqual(1, readyList.Count);
		}

		[TestMethod]
		public void Method_Run_Should_Failed_Event_When_Sending_Thrown_Exception()
		{
			var storage = new InMemoryReminderStorage();
			storage.Add(new ReminderItem(DateTimeOffset.Now, null, null));

			bool failedEventCalled = false;

			using (var domain = new ReminderDomain(
				storage,
				TimeSpan.FromMilliseconds(50),
				TimeSpan.FromSeconds(50)))
			{

				//do test
				domain.Run();
				domain.SendReminder += (reminder) =>
				{
					throw new Exception("test Exception");
				};

				domain.SendingFailed += (s, e) =>
				{
					if (e.SendingException.Message == "test exception")
						failedEventCalled = true;
				};

				Thread.Sleep(1200);
			}
			//check result
			Assert.IsTrue(failedEventCalled);
		}
	}
}
