using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12HomeWork
{
    public class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm
        {
            get
            {
                return DateTime.Now - AlarmDate;
            }
        }
        public bool IsOutdated
        {
            get
            {
                return DateTime.Now >= AlarmDate;
            }
        }

        public ReminderItem(DateTimeOffset date, string message)
        {
            AlarmDate = date;
            AlarmMessage = message;
        }

        public virtual string WriteProperties()
        {
            return $"Type: {GetType()} \n" +
                $"AlarmDate: {AlarmDate} \n" +
                $"AlarmMessage: {AlarmMessage} \n" +
                $"TimeToAlarm: {TimeToAlarm} \n" +
                $"IsOutDate: {IsOutdated} \n";
        }
    }
}

