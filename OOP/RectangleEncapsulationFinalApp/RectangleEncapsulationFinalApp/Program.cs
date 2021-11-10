using RectangleEncapsulationFinalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapsulationFinalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.setWidthAndHeight(4, 10);
            Console.WriteLine(" Width Of Rectangle :" + r1.GetWidth());
            Console.WriteLine("Height Of Rectangle :" + r1.GetHeight());
            Console.ReadLine();
        }
    }
}
