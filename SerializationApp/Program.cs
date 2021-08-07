using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AccountApp.Model;

namespace SerializationApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account account, deSerializedAccount;
            account = new Account(10, "omkar", 1000);
            FileStream fileStream = new FileStream("account.txt", FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            account.Deposit(2000);
            account.Withdrawl(100);
            binaryFormatter.Serialize(fileStream, account);
            fileStream.Position = 0;
            deSerializedAccount = (Account)binaryFormatter.Deserialize(fileStream);
            PrintInfo(deSerializedAccount);
            fileStream.Close();
        }

        private static void PrintInfo(Account account)
        {
            Console.WriteLine("Account Name: " + account.AccName);
            Console.WriteLine("Account Number: " + account.AccNo);
            Console.WriteLine("Account Balance: " + account.Balance);
        }
    }
}
