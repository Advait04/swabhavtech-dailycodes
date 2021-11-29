using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateAppV2
{
    delegate void DPrintMessage(String name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage f1;

            f1 = (n) =>
              {
                  Console.WriteLine("Inside Lambda 1");
                  Console.WriteLine("Howdy Says" + n);
              };
            f1("Advait");

            f1 = (n) =>
              {
                  Console.WriteLine("Ola.. says" + n);
                  f1("Swabhav Tech");
              };
        }
    }
}
