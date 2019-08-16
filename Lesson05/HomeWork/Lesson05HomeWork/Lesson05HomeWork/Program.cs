using System;

namespace Lesson05HomeWork
{
    class Program
    {
        //Объявляем список фигур
        [Flags]
        enum Figures {
            Circle = 0x1,
            Triangle = 0x1 <<1,
            Rectangle = 0x1 <<2 }
        static void Main(string[] args)
        {
            //Выводим список фигур и парсим выбор
            Figures allFigures = Figures.Circle | Figures.Rectangle | Figures.Triangle;
            Console.WriteLine("Please, choose the figures from list of proposed:");
            Console.WriteLine(allFigures);
            Figures inpFigures = Figures.Rectangle; //По умолчанию фигурой является прямоугольник

            //Обрабатываем ошибку ввода фигуры
            try
            {
                inpFigures = (Figures)Enum.Parse(typeof(Figures), Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n" + "This figures is not in the list");
            }

            Console.WriteLine("\n" + $"Your figures - {inpFigures}");

            switch (inpFigures)
            {
                case Figures.Rectangle:
                    double a = 1;
                    double b = 1;
                    Console.WriteLine("\n" + "Please, enter the length of the rectangle:");
                    //Обрабатываем ошибку ввода данных
                    try
                    {
                        a = double.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n" + "Error");
                    }
                    finally
                    {
                        a++;
                    }
 
                    Console.WriteLine("\n" + "Please, enter the height of the rectangle:");
                    try
                    {
                        b = double.Parse(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("\n" + "Error");
                    }
                    finally
                    {
                        b++;
                    }

                    //Выводим данные и результаты вычислений
                    Console.WriteLine("\n" + $"Length = {a}");
                    Console.WriteLine("\n" + $"Height = {b}");
                    Console.WriteLine("\n" + $"Square = {a * b}");
                    Console.WriteLine("\n" + $"Perimeter = {2*(a + b)}");

                    break;

                case Figures.Circle:
                    double r = 1;
                    Console.WriteLine("\n" + "Please, enter the radius of circle:");
                    //Обрабатываем ошибку ввода данных
                    try
                    {
                        r = double.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n" + "Error");
                    }
                    finally
                    {
                        r++;
                    }

                    //Выводим данные и результаты вычислений
                    Console.WriteLine("\n" + $"Radius = {r}");
                    Console.WriteLine("\n" + $"Square = {Math.PI * Math.Pow(r, 2)}");
                    Console.WriteLine("\n" + $"Perimetr = {2 * Math.PI * r}");

                    break;

                case Figures.Triangle:
                    double c = 1;
                    Console.WriteLine("\n" + "Please, enter the side of triangle:");
                    //Обрабатываем ошибку ввода данных
                    try
                    {
                        c = double.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n" + "Error");
                    }
                    finally
                    {
                        c++;
                    }

                    //Выводим данные и результаты вычислений
                    Console.WriteLine("\n" + $"Side = {c}");
                    Console.WriteLine("\n" + $"Square = {(Math.Pow(c, 2) * Math.Sqrt(3)) / 2}");
                    Console.WriteLine("\n" + $"Perimetr = {3 * c}");

                    break;
                    

            }

            Console.WriteLine("\n" + "Press any key to continue...");
            Console.ReadKey();
        }
    }
}
