using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovableApp
{
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car Is Moving");
        }
    }
}
