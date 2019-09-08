using System;

namespace Lesson12HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //var day1 = "2012-03-01 00:00:00";
            //var day2 = "2019-10-18 15:20:00";
            //ReminderItem item1 = new ReminderItem(DateTimeOffset.Parse("2019-10-18 15:20:00"), "AlarmClock 1");
            //Console.WriteLine(item1.WriteProperties());

            //ReminderItem item2 = new ReminderItem(DateTimeOffset.Parse(day2), "AlarmClock 2");
            //Console.WriteLine("\n" + item2.WriteProperties());

            var objects = new ReminderItem[3];

            objects[0] = new ReminderItem(DateTimeOffset.Parse("2019-10-18 15:20:00"), "Object1");
            
            objects[1] = new PhoneReminderItem(DateTimeOffset.Parse("2019-09-12 14:00:00"), "Object2", "89778505767");
    
            objects[2] = new ChatReminderItem(
                DateTimeOffset.Parse("2019-12-22 03:00:00"),
                "Object3",
                "ChatName",
                "AccountName");

            for(int i=0; i<objects.Length; i++)
            {
                Console.WriteLine(objects[i].WriteProperties());
            }




            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
