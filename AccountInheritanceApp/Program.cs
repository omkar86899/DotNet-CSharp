using System;
using AccountInterfaceApp.Model;

namespace AccountInterfaceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account savingAccount = new SavingAccount(10, "omkar", 1500);
            Account currentAccount = new CurrentAccount(11, "sagar", 2000);
            Console.WriteLine("Printing Saving Account Info: ");
            PrintAccountInfo(savingAccount);
            try
            {
                savingAccount.Withdrawl(1100);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            savingAccount.Deposit(2000);
            Console.WriteLine("Printing Saving Account Info After Deposit and Withdraw:");
            PrintAccountInfo(savingAccount);
            Console.WriteLine("Printing Current Account Info: ");
            PrintAccountInfo(currentAccount);
            try
            {
                currentAccount.Withdrawl(1100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            currentAccount.Deposit(2000);
            Console.WriteLine("Printing Current Account Info After Deposit and Withdraw:");
            PrintAccountInfo(currentAccount);
            Console.WriteLine("Total Number of Accounts Created: "+Account.HeadCount);
        }

        private static void PrintAccountInfo(Account account)
        {
            Console.WriteLine("Account No: " + account.AccountNo);
            Console.WriteLine("Account Name: " + account.AccountName);
            Console.WriteLine("Account Balance: " + account.Balance);
        }
    }
}
