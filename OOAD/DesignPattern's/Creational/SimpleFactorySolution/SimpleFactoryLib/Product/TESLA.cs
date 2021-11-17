using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    class TESLA:IAuto
    {
        public void Start()
        {
            Console.WriteLine("TESLA Started");
        }
        public void Stop()
        {
            Console.WriteLine("TESLA Stopped");
        }
    }
}
