using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapsulationDryApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;

        public void SetWeight(int pwidth)
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

