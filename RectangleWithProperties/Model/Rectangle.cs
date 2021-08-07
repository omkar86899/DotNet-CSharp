using System;

namespace RectangleWithProperties.Model
{
    public class Rectangle
    {
        private int _height, _width;
        private BorderStyle _border;

        public BorderStyle Border
        {
            get { return _border; }
            set { _border = value; }
        }
        public int Height
        {
            get { return _height; }
        }
        public int Width
        {
            get { return _width; }
        }

        public Rectangle(int width, int height):this(width,height,BorderStyle.SOLID)
        {
        }

        public Rectangle(int width, int height, BorderStyle border)
        {
            _width = width;
            _height = height;
            _border = border;
        }

    }
}
