using System;

namespace SimpleDelegateApp
{
    class Program
    {
        private delegate void DPrintMessage(String name);
        public static void Main(string[] args)
        {
            DPrintMessage msg;
            msg = PrinHello;
            msg("omkar");
            msg += PrintGoodBye;
            msg("omkar");
        }

        private static void PrinHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        private static void PrintGoodBye(string name)
        {
            Console.WriteLine("GoodBye " + name);
        }

        private static void foo()
        {

        }
    }
}
