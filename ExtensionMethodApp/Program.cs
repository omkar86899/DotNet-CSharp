using System;
using ExtensionMethodApp.Extension;

namespace ExtensionMethodApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            String name = "Omkar Bhosale";
            Console.WriteLine(name.Foo());
            Console.WriteLine(name.TooSnakeCase());
        }
    }
}
