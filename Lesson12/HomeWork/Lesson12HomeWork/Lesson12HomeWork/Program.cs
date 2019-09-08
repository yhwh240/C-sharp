using System;

namespace Lesson12HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
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
