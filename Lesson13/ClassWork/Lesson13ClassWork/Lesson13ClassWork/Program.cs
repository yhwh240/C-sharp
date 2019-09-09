using System;

namespace Lesson13ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			var plane1 = new Plane(200, 6);
			plane1.TakeUpper(210);
			plane1.WriteAllProperties();

			Console.WriteLine();

			var helicopter1 = new Helicopter(100, 3);
			helicopter1.TakeUpper(110);
			helicopter1.WriteAllProperties();



			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}
}
