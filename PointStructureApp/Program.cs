using System;
namespace PointStructureApp
{
    class Program
    {
        struct Point
        {
            private int _x, _y;
            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public int X
            {
                get { return _x; }
                set { _x = value; }
            }
            public int Y
            {
                get { return _y; }
                set { _y = value; }
            }
        };

        public static void Main(string[] args)
        {
            Point point = new Point(10, 20);
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
