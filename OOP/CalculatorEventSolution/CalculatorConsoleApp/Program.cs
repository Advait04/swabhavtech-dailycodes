using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.OnAddOperationComplete += PrintDetails;
            cal.AddNumber(8,5);
            cal.OnSubtractOperationComplete += PrintDetails;
            cal.SubstractNumber(10, 5);

            Console.ReadKey();
        }
        static void PrintDetails(string type, int first, int second, double result)
        {
           
            Console.WriteLine("First Number : {0}\nSecond Number: {1}\nType: {2}\nResult: {3}", first, second, type, result);
        }
    }
}
