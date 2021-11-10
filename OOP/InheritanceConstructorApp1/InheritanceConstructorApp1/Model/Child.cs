using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceConstructorApp1.Model
{
    class Child : Parent
    {
        public Child():base()
        {
            Console.WriteLine("Child Created");
        }
    }
}
