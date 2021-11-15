using DIPSolutionApp.HighLevelModule;
using DIPSolutionApp.LowLevelSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new TaxCalculator(new DBLogger());
            Console.WriteLine(calculator.Calculate(20, 10));
            Console.WriteLine(calculator.Calculate(30, 0));
            Console.ReadKey();
        }
    }
}
