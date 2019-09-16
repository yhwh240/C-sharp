using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13HomeWork1
{
	public class MultipleLogWriter : BaseLogWriter
	{
		IList<ILogWriter> _logWriters;

		public MultipleLogWriter(IList<ILogWriter> logWriters)
		{
			_logWriters = logWriters;
		}

		public override void Dispose()
		{
			foreach(ILogWriter logWriter in _logWriters)
			{
				logWriter.Dispose();
			}
		}

		public override void LogSingleRecord(LogMessageType logMessageType, string message)
		{
			foreach(var logWriter in _logWriters)
			{
				logWriter.LogSingleRecord(logMessageType, message);
			}
		}
	}
}
