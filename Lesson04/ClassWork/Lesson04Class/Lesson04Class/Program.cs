using System;

namespace Lesson04Class
{
    class Program
    {
        //enum Day
        //{
        //    Sunday = -10,
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday
        //};
        //enum Month : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
            [Flags]
            enum WindDirection
        {
            None,
            North = 1,
            East = 1 << 1,
            South = 1 << 2,
            West = 1 << 3
        }


        static string ToBynaryString(int a)
        {
            return Convert.ToString(a, 2).PadLeft(32, '0') + $" ({a})";
        }



        static void Main(string[] args)
        {
            //int a = 18;
            //int b = a++;
            //Console.WriteLine("Равно: "+ (a == b));
            //Console.WriteLine("Не равно: " + (a != b));
            //Console.WriteLine("Больше: " + (a > b));
            //Console.WriteLine("Меньше: " + (a < b));
            //Console.WriteLine("Больше, либо равно: " + (a >= b));
            //Console.WriteLine("Меньше, либо равно: "+(a <= b));


            //Округление чисел: Convert.ToInt32
            //double i = 9.49;
            //double j = 9.5;
            //double k = 10.49;
            //double l = 10.5;
            //double m = 10.51;
            //Console.WriteLine(Convert.ToInt32(i)); // 9
            //Console.WriteLine(Convert.ToInt32(j)); // 10
            //Console.WriteLine(Convert.ToInt32(k)); // 10
            //Console.WriteLine(Convert.ToInt32(l)); // it will be 10!
            //Console.WriteLine(Convert.ToInt32(m)); // 11


            //Console.WriteLine(Convert.ToBase64String(new byte[] { 0x0A, 0x0C }));

            //Округление чисел: Math.Round
            //Console.WriteLine(Math.Round(10.5, MidpointRounding.ToEven)); // 10, до ближайшего чётного
            //Console.WriteLine(Math.Round(10.5, MidpointRounding.AwayFromZero)); // 11, обычное округление

            //Console.WriteLine(Math.Round(4.0 / 3, 2)); // кол-во знаков после запятой - 2


            //Приведение к целому: Floor и Ceiling
            //var d1 = 7.03m;
            //var d2 = 7.64m;
            //var d3 = 0.12m;
            //var d4 = -0.12m;
            //var d5 = -7.1m;
            //var d6 = -7.6m;
            //Console.WriteLine("{0}, {1}", Math.Ceiling(d1), Math.Floor(d1)); // 8, 7
            //Console.WriteLine("{0}, {1}", Math.Ceiling(d2), Math.Floor(d2)); // 8, 7
            //Console.WriteLine("{0}, {1}", Math.Ceiling(d3), Math.Floor(d3)); // 1, 0
            //Console.WriteLine("{0}, {1}", Math.Ceiling(d4), Math.Floor(d4)); // 0, -1
            //Console.WriteLine("{0}, {1}", Math.Ceiling(d5), Math.Floor(d5)); // -7, -8
            //Console.WriteLine("{0}, {1}", Math.Ceiling(d6), Math.Floor(d6)); // -7, -8



            //Самостоятельная Math/MathF:

            //Console.WriteLine("Please enter first number;");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter second number;");
            //double h = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"Square = {3 * a * h} ");
            //Console.WriteLine($"Square Bok = {(3  * a * (a * Math.Sqrt(3) + 2 * h))/2} ");
            //Console.WriteLine($"V = {(Math.Pow(a, 2)  * h * Math.Sqrt(3))/2}");

            //Приведение любого значения к строке

            //int number = 12;
            //Console.WriteLine(number.ToString()); // 12
            //bool boolean = true;
            //Console.WriteLine(boolean.ToString()); // True
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now.ToString()); // 1/1/2019 2:15:00 PM
            //object me = new object();
            //Console.WriteLine(me.ToString()); // System.Object
            //string str = "abc";
            //Console.WriteLine(str.ToString()); // abc :)

            //enum:
            //Day today = Day.Monday;
            //int dayNumber = (int)today;
            //Console.WriteLine("{0} is day number #{1}.", today, dayNumber);
            //Month thisMonth = Month.Aug;
            //byte monthNumber = (byte)thisMonth;
            //Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);

            //побитовые операторы

            int a = 3; //00000011
            int b = int.MaxValue; //00000101
            


            Console.WriteLine(ToBynaryString(a));
            Console.WriteLine(ToBynaryString(~a));
            Console.WriteLine(ToBynaryString(b));           
            Console.WriteLine(ToBynaryString(~b));
            Console.WriteLine(ToBynaryString(a | b));
            Console.WriteLine(ToBynaryString(a & b));
            Console.WriteLine(ToBynaryString(a ^ b));

            Console.WriteLine();
            Console.WriteLine();


            int shiftSample = 7;
            Console.WriteLine(ToBynaryString(shiftSample));
            Console.WriteLine(ToBynaryString(shiftSample << 1));
            Console.WriteLine(ToBynaryString(shiftSample << 2));
            Console.WriteLine(ToBynaryString(shiftSample << 3));
            Console.WriteLine(ToBynaryString(shiftSample << 4));

            Console.WriteLine();
            Console.WriteLine();

            WindDirection wd = WindDirection.East | WindDirection.North;
            Console.WriteLine(ToBynaryString((int)WindDirection.None));
            Console.WriteLine(ToBynaryString((int)WindDirection.North));
            Console.WriteLine(ToBynaryString((int)WindDirection.East));
            Console.WriteLine(ToBynaryString((int)WindDirection.South));
            Console.WriteLine(ToBynaryString((int)WindDirection.West));
            Console.WriteLine(ToBynaryString((int)wd));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(string.Join("| ", new[] { 1, 2, 4, 8 }));

            Console.WriteLine(wd);






            Console.ReadKey();
        }

        
    }
}
