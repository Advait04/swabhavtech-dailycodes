using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            
            DPrintMessage f1;
            f1 = PrintHello;
            f1("Advait");

            f1 = PrintGoodbye;
            f1("Rohit");
           
            MessageWizard(f1);
            MessageWizard(PrintHello);
            MessageWizard(PrintGoodbye);

            DPrintMessage f2;
            f2 = PrintHello;
            f2 += PrintGoodbye;
            f2 += PrintHello;
            f2 += PrintGoodbye;

            f2("Swabhav Tech");

            Console.ReadKey();
        }
        public static void PrintHello(string name)
        {
            Console.WriteLine("Hello Says {0}", name);
        }
        public static void PrintGoodbye(string name)
        {
            Console.WriteLine("GoodBye says {0}", name);
        }
        public static void PrintFoo()
        {

        }
        public static void MessageWizard(DPrintMessage funct)
        {
            Console.WriteLine("Inside MessageWizard");
            funct("CHAMP");
        }
    }
}