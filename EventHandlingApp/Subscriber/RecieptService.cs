using System;
using EventHandlingApp.Publisher;

namespace EventHandlingApp.Subscriber
{
    public class RecieptService
    {
        public void PrintReceipt(Account acc)
        {
            Console.WriteLine("Generating receipt balance of Account Holder: " + acc.Balance);
        }
    }
}
