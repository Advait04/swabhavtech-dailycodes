using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleFiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius,perimeter,area;
            ConsoleColor BorderColor = ConsoleColor.Red;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * 3.14 * radius;
            area = 3.14 * Math.Pow(radius, 2);

            Console.WriteLine("Radius Of Circle :" + radius);
            Console.WriteLine("Area Of Circle :" + area);
            Console.WriteLine("Perimeter Of Circle: " + perimeter);
            Console.WriteLine("Colour Of Background :" + BorderColor);
        }
    }
}
