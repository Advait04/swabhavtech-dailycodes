using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Kid : Men
    {
        override public void Play()
        {
            Console.WriteLine("Kid Is Playing");
        }
    }
}
