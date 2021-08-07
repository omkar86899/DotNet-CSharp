using System;
using System.Reflection;
using AccountApp.Model;

namespace AccountReflectionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            DoReflection(typeof(Account));
        }

        private static void DoReflection(Type type)
        {
            int noOfGetters = 0, noOfSetters = 0;
            Console.WriteLine("Name of Class: " + type.Name);
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("Total No of Methods: " + methods.Length);
            Console.WriteLine("Printing All Getters: ");
            foreach (MethodInfo method in methods)
            {
                if (IsGetter(method))
                {
                    Console.WriteLine(method.Name);
                    noOfGetters++;
                }
            }
            Console.WriteLine("Number of getters: " + noOfGetters);
            Console.WriteLine("Printing All Setters: ");
            foreach (MethodInfo method in methods)
            {
                if (IsSetter(method))
                {
                    Console.WriteLine(method.Name);
                    noOfSetters++;
                }
            }
            Console.WriteLine("Number of setters: " + noOfSetters);
        }

        private static bool IsSetter(MethodInfo method)
        {
            if (method.Name.StartsWith("set") || method.Name.StartsWith("Set"))
            {
                return true;
            }
            return false;
        }

        private static bool IsGetter(MethodInfo method)
        {
            if (method.Name.StartsWith("get") || method.Name.StartsWith("Get"))
            {
                return true;
            }
            return false;
        }
    }
}
