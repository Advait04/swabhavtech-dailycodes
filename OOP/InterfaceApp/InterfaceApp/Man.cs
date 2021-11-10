using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp
{
    class Man : IManner
    {
        public void Depart()
        {
            Console.WriteLine("Man Depart's");
        }

        public void Wish()
        {
            Console.WriteLine("Man Wishes's");
        }
    }
}
