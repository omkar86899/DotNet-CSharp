using System;
using EventHandlingApp.Publisher;

namespace EventHandlingApp.Subscriber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account acc = new Account(10, "omkar", 1000);
            RecieptService recieptService = new RecieptService();
            SmsService smsService = new SmsService();
            RefreshBalanceService refreshBalanceService = new RefreshBalanceService();
            acc.BalanceChanged += smsService.SendSms;
            acc.BalanceChanged += refreshBalanceService.RefreshBalance;
            acc.BalanceChanged += recieptService.PrintReceipt;
            acc.Deposit(1000);
            acc.Withdrawl(200);
        }
    }
}
