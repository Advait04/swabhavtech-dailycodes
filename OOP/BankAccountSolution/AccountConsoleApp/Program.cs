using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101,"advait",1000);
            Console.WriteLine(acc1.GetCount());
            Account acc2 = new Account(102, "Vallab", 2000);
            Console.WriteLine(acc1.GetCount());
            Account acc3 = new Account(103, "Arati", 3000);
            Console.WriteLine(acc1.GetCount());
            Account acc4 = new Account(104, "Yogeshwar",4000);
            Console.WriteLine(acc1.GetCount());
        }
    }
}
