using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleConstructorApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;

        private Rectangle(int w, int h )
        {
           this.width = w;
            this.height = h;
        }

        private void SetWidth(int pwidth)
        {
            width = pwidth;
        }
        public int GetWidth()
        {
            return width;
        }
        public void SetHeight(int pheight)
        {
            height = pheight;
        }
        public int GetHeight()
        {
            return height;
        }
        public int CalculateArea()
        {
            int area = width * height;
            return area;
        }

        

       
    }
}
