using System;

namespace Lesson06HomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            do
            {
                Console.WriteLine("\n Please, enter natural number, no more than 2 billion: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error!" +"\n" + e);
                    continue;
                }

            } while (number == 0);

            Console.WriteLine($"Your number is '{number}'");

            string numbers = Convert.ToString(number);
            int i = 0;

            foreach(char num in numbers)
            {
                if(num % 2 == 0)
                {
                    i++;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Your number '{number}' contains {i} even numerals");





            Console.ReadKey();
        }
    }
}
