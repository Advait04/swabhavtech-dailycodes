using FactoryMethodLib.Product1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    class Bmw:IAuto
    {
        public void Start()
        {
            Console.WriteLine("BMW Started");
        }
        public void Stop()
        {
            Console.WriteLine("BMW Stopped");
        }
    }
}
