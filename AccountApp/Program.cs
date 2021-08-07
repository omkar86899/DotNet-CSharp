using System;
using AccountApp.Model;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(10, "omkar", 4000);
            Account a2 = new Account(11, "sagar");
            Console.WriteLine("Printing Account a1 Information: ");
            PrintInfo(a1);
            a1.Deposit(1000);
            try
            {
                a1.Withdrawl(4600);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Printing Account a1 information after deposit and withdrawl: ");
            PrintInfo(a1);
            Console.WriteLine("Printing Account a2 Information: ");
            PrintInfo(a2);
            Console.WriteLine("Total Accounts Created: "+Account.HeadCount);
        }

        private static void PrintInfo(Account a)
        {
            Console.WriteLine("Account Number: " + a.AccNo);
            Console.WriteLine("Account Name: " + a.AccName);
            Console.WriteLine("Account Balance: " + a.Balance);
        }
    }
}
