using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapsulationFinalApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;

        public int Validate(int vValidate)
        {
            if (vValidate < 100 && vValidate >= 1)
            {
                return vValidate;
            }
            else if (vValidate < 1)
            {
                return 1;
            }
            else if (vValidate > 100)
            {
                return 100;
            }
            return vValidate;
        }
        public void setWidthAndHeight(int widthParameter, int heightParameter)
        {
            width = Validate(widthParameter);
            height = Validate(heightParameter);

        }
        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }
    }
}
