using System;
using AccountApp.Model;
using System.Reflection;
using CustomAttributeApp.Model;

namespace CustomAttributeApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Getting all methods which have NeedToRefactor Attribute");
            DoReflection(typeof(Account));
        }

        private static void DoReflection(Type type)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Attribute attribute = method.GetCustomAttribute(typeof(NeedToRefactor));
                if(attribute is NeedToRefactor)
                {
                    Console.WriteLine(method.Name);
                }
            }
        }
    }
}
