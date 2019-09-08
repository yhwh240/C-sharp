using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12HomeWork
{
    public class PhoneReminderItem: ReminderItem
    {
        public string PhoneNumber { get; set; }


        public PhoneReminderItem(DateTimeOffset date, string message, string phoneNumber) 
            : base(date, message)
        {
            PhoneNumber = phoneNumber;
        }

        public override string WriteProperties()
        {
            return $"Type: {GetType()} \n" +
                $"AlarmDate: {AlarmDate} \n" +
                $"AlarmMessage: {AlarmMessage} \n" +
                $"TimeToAlarm: {TimeToAlarm} \n" +
                $"IsOutDate: {IsOutdated} \n" +
                $"PhoneNumber: {PhoneNumber} \n";
        }
    }
}
