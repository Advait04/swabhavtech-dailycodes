using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10,5);
            r.SetWidth(10);
            r.SetHeight(5);
            Console.WriteLine("Area Of Annouymous Object is" + new Rectangle(8, 3));
            displayInfo(new Rectangle(10, 5));
            Rectangle[] rectangles = new Rectangle[4];
            Console.WriteLine();
            rectangles[0] = new Rectangle(11, 3);
            displayInfo(rectangles[0]);
            rectangles[1] = new Rectangle(17, 5);
            displayInfo(rectangles[1]);
            rectangles[2] = new Rectangle(18, 4);
            displayInfo(rectangles[2]);
            rectangles[3] = new Rectangle(25, 8);
            displayInfo(rectangles[3]);



        }
        public static void displayInfo(Rectangle r)
        {
            Console.WriteLine("Width:" + r.GetWidth());
            Console.WriteLine("Height:" + r.GetHeight());
            Console.WriteLine("Area is :" + r.CalculateArea());
        }
    }
}

