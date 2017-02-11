using System;
using Microsoft.ServiceBus.Messaging;

namespace ServiceBusQueueReceiver
{
    internal class Program
    {
        private const string ConnectionString = "Enter your listen connection string here=";
        private const string QueueName = "randomword";

        private static void Main()
        {
            var client = QueueClient.CreateFromConnectionString(ConnectionString, QueueName);
            client.OnMessage(m => {
                Console.WriteLine($"Message {m.MessageId} received; contains word {m.GetBody<string>()}");
            });

            Console.Read();
        }
    }
}
