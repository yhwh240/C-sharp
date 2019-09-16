using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson13HomeWork1
{
	public class FileLogWriter : BaseLogWriter
	{
		private StreamWriter _logFileWriter;
		private string _logFileName;

		public FileLogWriter(string fileName = "log.txt")
		{
			_logFileName = fileName;
			_logFileWriter = new StreamWriter(
				File.Open(
					_logFileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));

			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		public override void LogSingleRecord(LogMessageType logMessageType, string message)
		{
			_logFileWriter.WriteLine(GetFormatMessage(logMessageType, message));
		}

		public override void Dispose()
		{
			if (_logFileWriter != null)
				_logFileWriter.Dispose();
		}
	}
}
