using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleApp
{
   public class Circle
    {
        public int radius;
        public string color;

        public  double  AreaOfCircle()
        {
            double area = 3.14*radius*radius;
            return area;
            

        }

        public double  PerimeterOFCircle()
        {
            double perimeter = 2*3.14*radius;
            return perimeter;
            
        }

    }
}
