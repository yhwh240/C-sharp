using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13HomeWork1
{
	public interface ILogWriter: IDisposable
	{
		void LogInfo(string message);

		void LogWarning(string message);

		void LogError(string message);
		void LogSingleRecord(LogMessageType logMessageType, string message);


	}
}
