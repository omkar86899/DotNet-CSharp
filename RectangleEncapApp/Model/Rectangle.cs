using System;

namespace RectangleEncapApp.Model
{
    public class Rectangle
    {
        private int _height, _width;
        private BorderStyle _border;

        public Rectangle(int width, int height) : this(width, height, BorderStyle.SOLID)
        {
        }

        public Rectangle(int width, int height, BorderStyle border)
        {
            _width = width;
            _height = height;
            _border = border;
        }

        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public BorderStyle GetBorder()
        {
            return _border;
        }

        public void SetBorderStyle(BorderStyle border)
        {
            _border = border;
        }
    }
}
