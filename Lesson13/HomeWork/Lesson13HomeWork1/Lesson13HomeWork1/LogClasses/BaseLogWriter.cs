using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13HomeWork1
{
	public abstract class BaseLogWriter: ILogWriter
	{
		private string _message { get; set; } = "{0:yyyy-MM-ddThh:mm:ss}+0000 \t {1} \t {2}";

		protected string GetFormatMessage(LogMessageType logMessageType, string mesage)
		{
			return string.Format(_message, DateTime.UtcNow, logMessageType, mesage);
		}

		public void LogInfo(string message)
		{
			LogSingleRecord(LogMessageType.Info, message);
		}

		public void LogWarning(string message)
		{
			LogSingleRecord(LogMessageType.Warning, message);
		}

		public void LogError(string message)
		{
			LogSingleRecord(LogMessageType.Error, message);
		}

		public abstract void LogSingleRecord(LogMessageType logMessageType, string message);

		public abstract void Dispose();
	}
}
