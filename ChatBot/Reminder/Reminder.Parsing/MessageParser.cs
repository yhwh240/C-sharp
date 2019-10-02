﻿using System;

namespace Reminder.Parsing
{
    public static class MessageParser
    {
        public static ParsedMessage Parse(string message)
        {
            // 2019-10-02T21:20:00 Congratгlations guys!

            int spaceIndex = message.IndexOf(' ');

            var result = new ParsedMessage
            {
                Date = DateTimeOffset.Parse(message.Substring(0, spaceIndex)),
                Message = message.Substring(spaceIndex + 1)
            };

            return result;
        }
    }
}
