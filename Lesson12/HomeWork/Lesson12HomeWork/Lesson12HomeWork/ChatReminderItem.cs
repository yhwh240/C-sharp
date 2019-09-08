using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12HomeWork
{
    class ChatReminderItem: ReminderItem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }

        public ChatReminderItem(DateTimeOffset date, string message, string chatName, string accName)
            : base(date, message)
        {
            ChatName = chatName;
            AccountName = accName;
        }

        public override string WriteProperties()
        {
            return $"Type: {GetType()} \n" +
                $"AlarmDate: {AlarmDate} \n" +
                $"AlarmMessage: {AlarmMessage} \n" +
                $"TimeToAlarm: {TimeToAlarm} \n" +
                $"IsOutDate: {IsOutdated} \n" +
                $"ChatName: {ChatName} \n" +
                $"AccountName: {AccountName} \n";
        }
    }
}
