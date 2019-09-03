using System;

namespace Lesson11HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1 = "2012-03-01 00:00:00";
            var day2 = "2019-10-18 15:20:00";
            ReminderItem item1 = new ReminderItem(DateTimeOffset.Parse(day1), "AlarmClock 1");
            Console.WriteLine(item1.WriteProperties());

            ReminderItem item2 = new ReminderItem(DateTimeOffset.Parse(day2), "AlarmClock 2");
            Console.WriteLine("\n" + item2.WriteProperties());




            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
