using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Boy : Men
        
    {
        public void Jump()
        {
            Console.WriteLine("Boy is Jumping");
        }
       override public void Play()
        {
            Console.WriteLine("Men is Playing");
        }
       
    }
}
