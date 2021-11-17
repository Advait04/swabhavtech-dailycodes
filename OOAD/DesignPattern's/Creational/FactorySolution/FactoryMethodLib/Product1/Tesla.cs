using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product1
{
    class Tesla:IAuto
    {
        public void Start()
        {
            Console.WriteLine("Tesla is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla is stopping");
        }
    }
}
