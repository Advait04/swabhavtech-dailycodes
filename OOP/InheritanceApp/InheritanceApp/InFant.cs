using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class InFant : Men
    {
        override public void Play()
        {
            Console.WriteLine("InFant Is Playing");
        }
    }
}
