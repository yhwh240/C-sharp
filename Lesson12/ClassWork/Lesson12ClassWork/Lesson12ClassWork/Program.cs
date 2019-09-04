using System;

namespace Lesson12ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseDocument doc = new BaseDocument(
				"Doc1",
				"1",
				DateTimeOffset.Parse("2019-04-05"));
			doc.WriteToConsole();

			Passport doc2 = new Passport(
				"2",
				DateTimeOffset.Parse("2019-06-07"),
				"Russia",
				"Artem"
			);
			doc2.WriteToConsole();

			BaseDocument doc3 = new Passport(
				"3",
				DateTimeOffset.Parse("2019-08-09"),
				"German",
				"Schulthz"
			);
			doc3.WriteToConsole();
			Console.WriteLine();

			var documents = new BaseDocument[3];

			documents[0] = new BaseDocument(
				"Doc4",
				"4",
				DateTimeOffset.Parse("2019-06-08"));
			documents[1] = new Passport(
				"5",
				DateTimeOffset.Parse("2019-06-07"),
				"Egipt",
				"Heopth");
			documents[2] = new BaseDocument(
				"Doc6",
				"6",
				DateTimeOffset.Parse("2019-06-08"));

			foreach(var document in documents)
			{
				if(document is Passport)
				{
					((Passport)document).ChangeIssueDate(DateTime.Now);
				}
				Console.WriteLine(document.PropertiesString);
			}



			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}
}
