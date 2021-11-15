using AccountPolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount acc1 = new SavingsAccount(101, "Rohit", 5000);
            PrintDetails(acc1);
            CurrentAccount  acc2 = new CurrentAccount(102, "Virat", 8000);
            PrintDetails(acc2);
            acc1.Withdraw(3000);
            PrintDetails(acc1);
            acc2.Withdraw(6000);
            PrintDetails(acc2);
        }
        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("\n Account Number:" + acc.accNo);
            Console.WriteLine("\n Account Name:" + acc.name);
            Console.WriteLine("\n Account Balance: " + acc.balance);
        }
    }
}
