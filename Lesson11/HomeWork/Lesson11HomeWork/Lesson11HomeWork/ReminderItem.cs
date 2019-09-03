using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11HomeWork
{
    class ReminderItem
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
                if (DateTime.Now >= AlarmDate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public ReminderItem(DateTimeOffset date, string message)
        {
            AlarmDate = date;
            AlarmMessage = message;
        }

        public string WriteProperties()
        {
            return $"AlarmDate: {AlarmDate}" + "\n" +
                $"AlarmMessage: {AlarmMessage}" + "\n" +
                $"TimeToAlarm: {TimeToAlarm}" + "\n" +
                $"IsOutDate: {IsOutdated} ";
        }
    }
}
