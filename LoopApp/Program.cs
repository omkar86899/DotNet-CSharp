using System;

namespace LoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Printing 2's Table Using For Loop");
            for (index = 1; index < 11; index++)
            {
                Console.WriteLine(index * 2);
            }
            Console.WriteLine("Printing 2's Table Using While Loop");
            index = 1;
            while (index < 11)
            {
                Console.WriteLine(index * 2);
                index++;
            }
            Console.WriteLine("Printing 2's Table Using For Each Loop");
            foreach(int i in array)
            {
                Console.WriteLine(i* 2);
            }
            Console.WriteLine("Printing 2's Table Using do while Loop");
            index = 1;
            do
            {
                Console.WriteLine(index * 2);
                index++;
            } while (index < 11);
        }
    }
}
