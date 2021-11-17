using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    class AUDI:IAuto
    {
        public void Start()
        {
            Console.WriteLine("Audi Started");
        }
        public void Stop()
        {
            Console.WriteLine("Audi Stopped");
        }
    }
}
