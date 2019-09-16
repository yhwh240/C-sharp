using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13HomeWork1
{
	public class ConsoleLogWriter : BaseLogWriter
	{
		public override void Dispose()
		{
			throw new NotImplementedException();
		}

		public override void LogSingleRecord(LogMessageType logMessageType, string message)
		{
			Console.WriteLine(GetFormatMessage(logMessageType, message));
		}
		
	}
}
