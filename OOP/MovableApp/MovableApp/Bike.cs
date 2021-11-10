using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovableApp
{
    class Bike : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bike Is Moving");
        }
    }
}
