using RectangleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapsulationApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Rectangle r1;
            r1 = new Rectangle();
            r1.Validate();
            r1.SetWidth(-10);

            Console.WriteLine("Enter Width:"+ r1.GetWidth());
            r1.SetHeigth(60);

            Console.WriteLine("Enter Heigth:" + r1.GetHeigth());

            Console.ReadLine();


            
            



        }
    }
}
