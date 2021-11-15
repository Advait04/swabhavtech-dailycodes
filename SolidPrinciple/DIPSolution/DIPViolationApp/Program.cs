using DIPViolationApp.HighLevelModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new TaxCalculator(LogPolicyType.DB);
            Console.WriteLine(calculator.Calculate(20, 10));
            Console.WriteLine(calculator.Calculate(20, 3));
            Console.ReadKey();
        }
    }
}
