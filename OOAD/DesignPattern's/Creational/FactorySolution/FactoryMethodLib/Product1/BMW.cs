using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product1
{
    class BMW:IAuto
    {
        public void Start()
        {
            Console.WriteLine("BMW is starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW is stopping");
        }
    }
}
