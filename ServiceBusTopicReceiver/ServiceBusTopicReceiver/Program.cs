using System;
using Microsoft.ServiceBus.Messaging;

namespace ServiceBusTopicReceiver
{
    internal class Program
    {
        private const string ConnString = "Enter your listen connection string here=";

        private static void Main()
        {
            var client = SubscriptionClient.CreateFromConnectionString(ConnString, "specificword", "GroupA");
            client.OnMessage(m =>
                {
                    Console.WriteLine($"Message {m.MessageId} received; word is {m.GetBody<string>()}");
                    m.Complete();
                }
            );

            Console.Read();
        }
    }
}
