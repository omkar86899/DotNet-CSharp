using System;
using PointClassApp.Model;

namespace PointClassApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Point point = new Point(10,20);
            UpdatePoint(point);
            PrintDetails(point);
        }

        private static void PrintDetails(Point point)
        {
            Console.WriteLine("X: " + point.X);
            Console.WriteLine("Y: " + point.Y);
        }

        private static void UpdatePoint(Point point)
        {
            point.X = 15;
            point.Y = 30;
        }
    }
}
