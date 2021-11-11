using OCPSolutionApp.Client;
using OCPSolutionApp.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fixedDeposit1 = new FixedDeposit("Advait", 50000, 5, new DiwaliFestivaalPolicy());
            Console.WriteLine("\nSimple Interest: {0}", fixedDeposit1.SimpleInterest());
            Console.ReadKey();
        }
    }
}
