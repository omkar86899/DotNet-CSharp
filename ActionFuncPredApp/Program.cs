using System;

namespace ActionFuncPredApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Predicate<String> CheckBigName = IsBigName;
            Predicate<int> IsEvenNumber = delegate (int no)
            {
                return no % 2 == 0;
            };
            Predicate<int> IsPrimeNumber = (no) =>
            {
                for (int i = 2; i < no / 2; i++)
                {
                    if (no % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            Func<int, long, double> Add = AddNumbers;
            Func<int, long, double> Substract = delegate (int n1, long n2)
            {
                return Convert.ToDouble(n1) - Convert.ToDouble(n2);
            };
            Func<int, long, double> Multiply = (n1, n2) =>
            {
                return Convert.ToDouble(n1) * Convert.ToDouble(n2);
            };

            Action Greetings = PrintHello;
            Action<String> GreetingsToPerson = delegate (String name)
            {
                Console.WriteLine("Hello " + name);
            };
            Action<String> SayGoodByeToPerson = (name) =>
            {
                Console.WriteLine("Good Bye " + name);
            };

            Console.WriteLine("Executing Predicates: ");
            Console.WriteLine(CheckBigName("Omkar Bhosale"));
            Console.WriteLine(IsEvenNumber(7));
            Console.WriteLine(IsPrimeNumber(15));

            Console.WriteLine("Executing Funcs: ");
            Console.WriteLine(Add(20, 10));
            Console.WriteLine(Substract(20, 10));
            Console.WriteLine(Multiply(20, 10));

            Console.WriteLine("Executing Actions: ");
            Greetings();
            GreetingsToPerson("omkar");
            SayGoodByeToPerson("omkar");
        }

        private static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        private static double AddNumbers(int n1, long n2)
        {
            return Convert.ToDouble(n1) + Convert.ToDouble(n2);
        }

        private static bool IsBigName(String name)
        {
            return name.Length >= 8;
        }
    }
}
