using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AccountApp.Model;

namespace DeSerializationApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("D:/.NET/C#/account.txt", FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Account account = (Account)binaryFormatter.Deserialize(fileStream);
            PrintInfo(account);
        }

        private static void PrintInfo(Account account)
        {
            Console.WriteLine("Account Name: "+account.AccName);
            Console.WriteLine("Account Number: "+account.AccNo);
            Console.WriteLine("Account Balance: "+account.Balance);
        }
    }
}
