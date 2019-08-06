using System;

namespace Lesson02Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            string numberOne = Console.ReadLine();
            float a = float.Parse(numberOne);

            Console.WriteLine("Please enter second number: ");
            string numberTwo = Console.ReadLine();
            float b = float.Parse(numberTwo);

            Console.WriteLine($"+ : {a} + ({b}) = {a + b}");
            Console.WriteLine($"- : {a} - ({b}) = {a - b}");
            Console.WriteLine($"* : {a} * ({b}) = {a * b}");

            Console.ReadKey();
        }
    }
}
