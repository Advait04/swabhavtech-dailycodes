using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoicePrinter = new InvoiceConsolePrinter();
            invoicePrinter.PrintInvoice(new Invoice(101, "personal Invoice", 300000, 20f, 7f));
            Console.ReadKey();
        }
    }
}
