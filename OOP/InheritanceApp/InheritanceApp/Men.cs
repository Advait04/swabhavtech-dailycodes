using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Men
    {
        public void Read()
        {
            Console.WriteLine("Men is  Reading");
        }
        public virtual void Play()
        {
            Console.WriteLine("Men is Playing");
        }
        public void Walk()
        {
            Console.WriteLine("Men is  Walking");
        }
    }
}
