using System;
using EventHandlingApp.Publisher;

namespace EventHandlingApp.Subscriber
{
    public class RefreshBalanceService
    {
        public void RefreshBalance(Account acc)
        {
            Console.WriteLine("Refreshing Account Balance");
        }
    }
}
