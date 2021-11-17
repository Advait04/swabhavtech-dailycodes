using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
   class BMW:IAuto
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
