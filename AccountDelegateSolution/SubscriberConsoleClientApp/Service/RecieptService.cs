using System;
using PublisherLib;

namespace SubscriberConsoleClientApp.Service
{
    public class RecieptService
    {
        public void PrintReceipt(Account acc)
        {
            Console.WriteLine("Generating receipt balance of Account Holder: " + acc.Balance);
        }
    }
}
