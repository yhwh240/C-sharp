using System;
using System.Text;//Кодировка
using System.Threading;//работа с потоками


namespace Lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Кодировка
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            Console.WriteLine("Enter your name: ");
            Console.WriteLine();
            string name = Console.ReadLine();
            Console.WriteLine();
            Thread.Sleep(5000);// остановка потока на 5 сек
            Console.WriteLine($"Hello, {name} !");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
