using System;

namespace Lesson03Home
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получение значений начала и конца числового порядка
            Console.WriteLine("Please enter initial number:");
            int initialNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter finit number:");
            int finitNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            //Определение длину массивов и создаём массивы, которые будем перемножать во время заполнения двумерного массива
            int massLength = finitNumber - initialNumber + 1;
            int[] mass1 = new int[massLength];
            int[] mass2 = new int[massLength];
            int[,] mass3 = new int[massLength, massLength];
            
            //С помощью цикла for заполняем одномерные массивы
            for(int i=0;i<massLength; i++)
            {
                mass1[i] = initialNumber + i;
                mass2[i] = initialNumber + i;
            }
            
            //С помощью двойного цикла заполняем и выводим элементы двумерного массива
            for(int i = 0; i<massLength; i++)
            {
                for(int j = 0; j<massLength; j++)
                {
                    mass3[i, j] = mass1[i] * mass2[j];
                    Console.Write(mass3[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
