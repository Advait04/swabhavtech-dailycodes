using CircleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle r1;
            r1 = new Circle();
            r1.SetRadius(12);
            Console.WriteLine("Radius OF Circle :" + r1.GetRadius());
            r1.SetColour("purple");
            Console.WriteLine("Colour OF Circle :" + r1.GetColour());
            Console.ReadLine();
        }
    }
}
