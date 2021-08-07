using System;
using EventHandlingApp.Publisher;

namespace EventHandlingApp.Subscriber
{
    public class SmsService
    {
        public void SendSms(Account acc)
        {
            Console.WriteLine("Sending SMS");
        }
    }
}
