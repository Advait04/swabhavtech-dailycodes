using SimpleFactoryLib.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryClientApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var factory = AutomobileFactory.GetInstance();
            var automobile = factory.Manufacture(Autotype.BMW);
            automobile.Start();
            automobile.Stop();
            Console.WriteLine(factory.GetHashCode());

            var factory2 = AutomobileFactory.GetInstance();
            var automobile2 = factory2.Manufacture(Autotype.BMW);
            automobile2.Start();
            automobile2.Stop();

            Console.WriteLine(factory2.GetHashCode());

            Console.ReadKey();
        }
    }
}
