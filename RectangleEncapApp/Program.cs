using System;
using RectangleEncapApp.Model;

namespace RectangleEncapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Rectangle rect1 = new Rectangle(10, 39, BorderStyle.DOTTED);
            prinInfo(rect);
            rect.SetBorderStyle(BorderStyle.DOTTED);
            Console.WriteLine("Printing after changing border");
            prinInfo(rect);
            Console.WriteLine("Printing rect1");
            prinInfo(rect1);

        }

        private static void prinInfo(Rectangle rect)
        {
            Console.WriteLine("heigth: "+rect.GetHeight());
            Console.WriteLine("width: "+rect.GetWidth());
            Console.WriteLine("Border: "+rect.GetBorder());
        }
    }
}
