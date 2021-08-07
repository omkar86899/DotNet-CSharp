using System;
using RectangleWithProperties.Model;

namespace RectangleWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Rectangle rect1 = new Rectangle(10, 30, BorderStyle.DOTTED);
            PrintInfo(rect);
            rect.Border = BorderStyle.DOTTED;
            Console.WriteLine("After changing Border:");
            PrintInfo(rect);
            Console.WriteLine("Printing info of Rect1:");
            PrintInfo(rect);
        }

        private static void PrintInfo(Rectangle rect)
        {
            Console.WriteLine("Border: "+rect.Border);
            Console.WriteLine("Height: "+rect.Height);
            Console.WriteLine("Width: "+rect.Width);
        }
    }
}
