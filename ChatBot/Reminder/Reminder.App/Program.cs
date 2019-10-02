using System;
using System.Net;
using Reminder.Domain;
using Reminder.Receiver.Telegram;
using Reminder.Sender.Telegram;
using Reminder.Storage.Core;
using Reminder.Storage.InMemory;
using Reminder.Receiver.Core;
using Reminder.Parsing;
using MihaZupan;

namespace Reminder.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telegram Bot Aplication!");

            var storage = new InMemoryReminderStorage();
            var domain = new ReminderDomain(storage);

            string token = "961862676:AAGPTkcJqLhOkgX7KOTOaEUe3Y3bjvIWJ24";
            IWebProxy proxy = new HttpToSocks5Proxy(
                "proxy.golyakov.net", 1080);

            var sender = new TelegramReminderSender(token, proxy);
            var receiver = new TelegramReminderReceiver(token, proxy);

            receiver.MessageReceived += (s, e) =>
            {
                Console.WriteLine($"Message received from contact id '{e.ContactId}' with text '{e.Message}'");

                //add new ReminderItem to the storage
                try
                {
                    var parsedMessage = MessageParser.Parse(e.Message);

                    var item = new ReminderItem(
                                        parsedMessage.Date,
                                        parsedMessage.Message,
                                        e.ContactId);
                    storage.Add(item);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Полученное не соответствует формату! \n {ex.Message}");
                }

            };

            receiver.Run();

            domain.SendReminder = (ReminderItem ri) =>
            {
                sender.Send(ri.ContactId, ri.Message);
            };

            domain.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
