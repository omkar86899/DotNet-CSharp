using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinqApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<String> names = args;

            var longNames = names.Where(name => name.Length > 5);
            var top2_longNames = longNames.Take(2);
            var namesInAscendingOrder = names.OrderBy(name => name);
            var namesWithVowelsInIt = names.Where(isVowel);
            var namesFirstFourCharacter = names.Select(name => name.Substring(0, 4));

            Console.WriteLine("Printing Long Names: ");
            PrintNames(longNames);
            Console.WriteLine("\nPrinting Top 2 Long Names: ");
            PrintNames(top2_longNames);
            Console.WriteLine("\nPrinting Names in Ascending Order: ");
            PrintNames(namesInAscendingOrder);
            Console.WriteLine("\nPrinting Names with vowels in it: ");
            PrintNames(namesWithVowelsInIt);
            Console.WriteLine("\nPrinting First Four Characters Of Names: ");
            PrintNames(namesFirstFourCharacter);
        }

        private static bool isVowel(string name)
        {
            Char[] vowels = { 'a','e','i','o','u'};
            Char[] nameArray = name.ToLower().ToCharArray();
            foreach(Char nameChar in nameArray)
            {
                if (vowels.Contains(nameChar))
                {
                    return true;
                }
            }
            return false;
        }

        private static void PrintNames(IEnumerable<string> longNames)
        {
            foreach (String name in longNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
