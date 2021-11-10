using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10;
            Rectangle big;
            Rectangle small;

            big = new Rectangle();
            small = new Rectangle();

            big.width = 100;
            big.height = 50;
            small.width = 50;
            small.height = 25;

            int areaOfBig = big.CalculateArea();
            int areaOfSmall = small.CalculateArea();

            Console.WriteLine("Widht Of Big recatngle :" + big.width);
            Console.WriteLine("Height Of Big rectangle :" + big.height);
            Console.WriteLine("Area of Big Rectangle :" + areaOfBig);
            Console.WriteLine("Width Of Small Rectangle :" + small.width);
            Console.WriteLine("Height Of Small Rectangle:" + small.height);
            Console.WriteLine("Area Of Small Rectangle :" + areaOfSmall);
        }
    }
}
