using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp
{
    class Boy : IManner,IEmotion 
    {
        public void Cry()
        {
            Console.WriteLine("Boy Is Crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy Depart's");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy Is Laughing");
        }

        public void Wish()
        {
            Console.WriteLine("Boy  Wishe's");
        }
    }
}
