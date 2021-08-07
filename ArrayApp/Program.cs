using System;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fruits = { "apple", "banana", "mango", "pineapple", "orange" };
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Operations on String array");
            Console.WriteLine("String Array: ");
            printArray(fruits);
            Console.WriteLine("Length of String Array: "+fruits.Length);
            Array.Reverse(fruits);
            Console.WriteLine("String Array after Reverse: ");
            printArray(fruits);
            Array.Sort(fruits);
            Console.WriteLine("String Array after Sort");
            printArray(fruits);
            Console.WriteLine("Index of banana: "+Array.IndexOf(fruits, "banana"));

            Console.WriteLine();
            Console.WriteLine("Operations on Integer array");
            Console.WriteLine("Integer Array: ");
            printArray(numbers);
            Console.WriteLine("Length of Integer Array: " + numbers.Length);
            Array.Reverse(numbers);
            Console.WriteLine("Integer Array after Reverse: ");
            printArray(numbers);
            Array.Sort(numbers);
            Console.WriteLine("Integer Array after Sort");
            printArray(numbers);
            Console.WriteLine("Index of 9: " + Array.IndexOf(numbers, 9));

            Console.WriteLine();
            Console.WriteLine("Operations on Character array");
            Console.WriteLine("Character Array: ");
            printArray(vowels);
            Console.WriteLine("Length of Char Array: " + vowels.Length);
            Array.Reverse(vowels);
            Console.WriteLine("Char Array after Reverse: ");
            printArray(vowels);
            Array.Sort(vowels);
            Console.WriteLine("Char Array after Sort");
            printArray(vowels);
            Console.WriteLine("Index of 'e': " + Array.IndexOf(vowels, 'e'));

        }

        private static void printArray(char[] vowels)
        {
            foreach(char vowel in vowels)
            {
                Console.WriteLine(vowel);
            }
        }

        private static void printArray(int[] numbers)
        {
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void printArray(string[] fruits)
        {
            foreach(String item in fruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
