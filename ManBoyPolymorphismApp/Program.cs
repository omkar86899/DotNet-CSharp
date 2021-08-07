using System;
using ManBoyPolymorphismApp.Model;

namespace ManBoyPolymorphismApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Case1();
        }

        private static void Case1()
        {
            Man man;
            man = new Boy();
            man.Play();
            man.Read();
        }
    }
}
