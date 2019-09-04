using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12ClassWork
{
	public class Passport : BaseDocument
	{
		public override string DocName { get => base.DocName; }
		public string Country { get; set; }
		public string PersonName { get; set; }

		public override string PropertiesString
		{
			get
			{
				return base.PropertiesString + $" | Country: {Country} | PersonName: {PersonName}";
			}
		}

		public Passport(string docnumber, DateTimeOffset issuedate, string country, string personname)
			: base("Passport", docnumber,issuedate)
		{
			Country = country;
			PersonName = personname;
		}

		public void ChangeIssueDate(DateTimeOffset newIssueDate)
		{
			base.IssueDate = newIssueDate;
		}

	}
}
