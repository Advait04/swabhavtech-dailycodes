using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Advait", 20000, 10, FestivalType.NORMAL);
            Console.WriteLine(fd1.SimpleInterest());
        }
    }
}
