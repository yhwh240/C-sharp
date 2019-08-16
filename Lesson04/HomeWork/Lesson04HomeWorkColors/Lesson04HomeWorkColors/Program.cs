using System;

namespace Lesson04HomeWorkColors
{
    class Program
    {
        //Объявляем цвета
        [Flags]
        enum Colors
        {
            //None = 0x0,
            Black = 0x1,
            Blue = 0x1 << 1,
            Cyan = 0x1 << 2,
            Grey = 0x1 << 3,
            Green = 0x1 << 4,
            Magenta = 0x1 << 5,
            Red = 0x1 << 6,
            White = 0x1 << 7,
            Yellow = 0x1 << 8
        }



        static void Main(string[] args)
        {
            //Объявляем переменные цвета и соотвествующего ему порядкового номера
            Colors colorBlack = Colors.Black;
            int numberBlack = (int)colorBlack;

            Colors colorBlue = Colors.Blue;
            int numberBlue = (int)colorBlue;

            Colors colorCyan = Colors.Cyan;
            int numberCyan = (int)colorCyan;

            Colors colorGrey = Colors.Grey;
            int numberGrey = (int)colorGrey;

            Colors colorGreen = Colors.Green;
            int numberGreen = (int)colorGreen;

            Colors colorMagenta = Colors.Magenta;
            int numberMagenta = (int)colorMagenta;

            Colors colorRed = Colors.Red;
            int numberRed = (int)colorRed;

            Colors colorWhite = Colors.White;
            int numberWhite = (int)colorWhite;

            Colors colorYellow = Colors.Yellow;
            int numberYellow = (int)colorYellow;

            //Выводим список палитры цветов
            Console.WriteLine("Please, select 4 colors, that you like, from the list of proposed: ");
            Console.WriteLine("{0}.{1}", numberBlack, colorBlack);
            Console.WriteLine("{0}.{1}", numberBlue, colorBlue);
            Console.WriteLine("{0}.{1}", numberCyan, colorCyan);
            Console.WriteLine("{0}.{1}", numberGrey, colorGrey);
            Console.WriteLine("{0}.{1}", numberGreen, colorGreen);
            Console.WriteLine("{0}.{1}", numberMagenta, colorMagenta);
            Console.WriteLine("{0}.{1}", numberRed, colorRed);
            Console.WriteLine("{0}.{1}", numberWhite, colorWhite);
            Console.WriteLine("{0}.{1}", numberYellow, colorYellow);

            //Помещаем все элементы в одну переменную
            Colors allColors = 0;
            allColors = Colors.Black | Colors.Blue | Colors.Cyan | Colors.Green | Colors.Grey | Colors.Magenta | Colors.Red | Colors.Yellow;

            //Парсим ввод порядковых номеров цветов
            Console.WriteLine();
            Console.WriteLine("Select number of color:");
            string inputColor = Console.ReadLine();
            string inputColor2 = Console.ReadLine();
            string inputColor3 = Console.ReadLine();
            string inputColor4 = Console.ReadLine();
            Colors inp1 = (Colors)Enum.Parse(typeof(Colors), inputColor);
            Colors inp2 = (Colors)Enum.Parse(typeof(Colors), inputColor2);
            Colors inp3 = (Colors)Enum.Parse(typeof(Colors), inputColor3);
            Colors inp4 = (Colors)Enum.Parse(typeof(Colors), inputColor4);

            //Выводим список понравившихся цветов
            Console.WriteLine();
            Console.WriteLine("List of favorite colors:");

            //Создаём переменную "Избранное"
            Colors favoriteColors = 0;
            favoriteColors = inp1 | inp2 | inp3 | inp4;
            //Console.WriteLine("{0}.{1}", inputColor, inp1);
            //Console.WriteLine("{0}.{1}", inputColor2, inp2);
            //Console.WriteLine("{0}.{1}", inputColor3, inp3);
            //Console.WriteLine("{0}.{1}", inputColor4, inp4);

            Console.WriteLine(string.Join("| ", new[] { favoriteColors }));

            //Вычитаем понравившиеся цвета из переменной allColors и выводим оставшееся содержимое
            Colors notFavoriteColors = 0;
            notFavoriteColors = allColors ^ favoriteColors;
            Console.WriteLine("List of color, that you not like: ");
            Console.WriteLine(string.Join("| ", new[] { notFavoriteColors }));



            Console.ReadKey();
        }
    }
}
