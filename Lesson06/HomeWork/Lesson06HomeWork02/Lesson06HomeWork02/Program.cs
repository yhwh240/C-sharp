using System;

namespace Lesson06HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            double downPaymentAmount = 100;
            double dailyIncomePercent = 0.0003;
            double desiredAccumulationAmount = 200;

            Console.WriteLine("Please, enter the amount of the down payment in rubles:");
            try
            {
                downPaymentAmount = Double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error!" + "\n" + e);
            }
            finally
            {
                Console.WriteLine("\n" + $"Amount of the down payment is {downPaymentAmount} rub");
            }


            Console.WriteLine("\n" + "Please, enter the daily income percent, as a decimal fraction (1% = 0.01):");
            try
            {
                dailyIncomePercent = Double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error!" + "\n" + e);
            }
            finally
            {
                Console.WriteLine("\n" + $"Daily income is {dailyIncomePercent}%");
            }


            Console.WriteLine("\n" + "Please enter the desired amount of savings in rubles:");
            try
            {
                desiredAccumulationAmount = Double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error!" + "\n" + e);
            }
            finally
            {
                Console.WriteLine("\n" + $"Your desired amount of savings is {desiredAccumulationAmount} rub");
            }

            int days = 0;
            double count = downPaymentAmount;

            do
            {
                count  += (count * dailyIncomePercent);
                days++;

            } while (count <= desiredAccumulationAmount);

            Console.WriteLine("\n" + $"The required number of days to accumulate the desired amount: {days}");
            Console.ReadKey();
        }
    }
}
