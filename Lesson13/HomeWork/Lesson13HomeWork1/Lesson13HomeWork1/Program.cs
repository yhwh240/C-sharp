using System;

namespace Lesson13HomeWork1
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleLogWriter logConsole = new ConsoleLogWriter();
			logConsole.LogWarning("test");
			logConsole.LogInfo("test");
			logConsole.LogError("test");

			var logFile = new FileLogWriter();
			logFile.LogError("test");
			logFile.LogInfo("test");
			logFile.LogWarning("test");

			ILogWriter[] a = new ILogWriter[2];
			a[0] = logConsole;
			a[1] = logFile;

			var multipleLogWriter = new MultipleLogWriter(a);
			foreach (var i in a)
			{
				i.LogInfo("multiply");
			}

			logFile.Dispose();

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}
}
