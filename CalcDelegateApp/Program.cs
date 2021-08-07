using System;

namespace CalcDelegateApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            DMathOperation mathOperation;
            mathOperation = Add;
            mathOperation += Sub;
            mathOperation += Multiply;
            mathOperation(20, 10);
        }

        delegate void DMathOperation(int firstNumber, int secondNumber);

        private static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Addition is: " + (firstNumber + secondNumber));
        }

        private static void Sub(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Substraction is: " + (firstNumber - secondNumber));
        }

        private static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Multiplication is: " + (firstNumber * secondNumber));
        }
    }
}
