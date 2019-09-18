using System;
using Figures;
using Newtonsoft;

namespace Lesson16ClassWork
{
	class Program
	{
		delegate double DoCalculation(double a, double b);

		static void Main(string[] args)
		{
			//rectangle r1 = new rectangle(5, 8);
			//double rectangleperimeter = r1.calculate((x, y) => 2 * (x + y));
			//double rectanglesquare = r1.calculate((x, y) => x * y);
			//console.writeline($"type: {r1.gettype()} | square: {rectanglesquare} | perimeter:{rectangleperimeter}");

			//circle cr1 = new circle(9);
			//double cr1perimeter = cr1.calculate(x => 2 * math.pi * x);
			//double cr1square = cr1.calculate(x => math.pi * math.pow(x, 2));
			//console.writeline($"type: {cr1.gettype()} | square: {cr1square} | perimeter:{cr1perimeter}");

			var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(
				new
				{
					Name = "Artem",
					Age = 20,
					Sex = 'M',
					IsActive = true
			});

			


			Console.WriteLine(jsonData);


			Console.ReadKey();
		}
	}
}
