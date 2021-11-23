using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Image I1 = new RealImage("one.jpg");
            Image I2 = new RealImage("two.jpg");
            Image I3 = new RealImage("three.jpg");
            I3.Display();
            Console.ReadLine();

            Image I4 = new RealImage("four.jpg");
            Image I5 = new RealImage("five.jpg");
            Image I6 = new RealImage("six.jpg");
            I6.Display();
            Console.ReadKey();
        }
    }
}
