using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12ClassWork
{
	public class BaseDocument
	{
		public virtual string DocName { get; set; }
		public string DocNumber { get; set; }
		public DateTimeOffset IssueDate { get; set; }
		public virtual string PropertiesString
		{
			get
			{
				return $"DocName: {DocName} | DocNumber: {DocNumber} | IssueDate: {IssueDate}";
			}
		}

		public BaseDocument(string docname, string docnumber, DateTimeOffset issuedate)
		{
			DocName = docname;
			DocNumber = docnumber;
			IssueDate = issuedate;
		}

		public void WriteToConsole()
		{
			Console.WriteLine(PropertiesString);
		}



	}
}
