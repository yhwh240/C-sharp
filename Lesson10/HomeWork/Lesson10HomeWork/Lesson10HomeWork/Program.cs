using System;

namespace Lesson10HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Person[] people = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                people[i] = new Person();
                Console.WriteLine($"Enter name {i}: ");
                people[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter age {i}: ");
                try
                {
                    people[i].Age = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error!" + "\n" + e);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(people[i].Descriprion);
            }


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
