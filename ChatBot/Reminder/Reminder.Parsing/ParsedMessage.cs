using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Parsing
{
    public class ParsedMessage
    {
        public string Message {get;set;}
        public DateTimeOffset Date { get; set; }
    }
}
