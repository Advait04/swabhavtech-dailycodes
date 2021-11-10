using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Circle circle = new Circle();

            big = new Circle();
            circle radius = 5;
            Circle.color = "Red";
            double areaOfCircle = Circle.AreaOfCircle();
            
            Console.WriteLine("Radius Of  Circle:" + circle.radius);
            Console.WriteLine("Area Of  Circle :" + areaOfCircle);
            Console.WriteLine("Color Of Circle :" + circle.color);

            double PerimeterOfCircle = circle.PerimeterOfCircle();
            Console.WriteLine("Perimeter Of  Circle:" + PerimeterOfCircle);
            Console.ReadLine();
           
           

        }
    }
}
