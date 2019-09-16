using System;

namespace Lesson15Class
{
	class Program
	{
		static void Main(string[] args)
		{
			Account<int, string> a1 = new Account<int, string>(1, "Artem");
			Account<string, string> a2 = new Account<string, string>("Second", "Alex");

			a1.WriteProperties();
			a2.WriteProperties();
	
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}
}
