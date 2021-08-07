using System;
using CalcLib;

namespace CalcConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.CheckEven(10));
            Console.WriteLine(calculator.CheckEven(15));
            Console.WriteLine(calculator.CheckPrime(3));
            Console.WriteLine(calculator.CheckPrime(15));
        }
    }
}
