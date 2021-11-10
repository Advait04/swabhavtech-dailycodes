using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new  Account(101, "Ram", 1500);
            acc1.Withdraw(1000);
            PrintDetails(acc1);

            Account acc2 = new Account(102, "Sham");
            acc2.Deposit(1000);
            PrintDetails(acc2);

            

        }

        public static void PrintDetails(Account acc1 )
        {
            Console.WriteLine("Account No :" + acc1.GetAccNo());
            Console.WriteLine("Account Holder's NAme :" + acc1.GetName());
            Console.WriteLine("Account Balance:" + acc1.GetBalance());
            Console.WriteLine();
        }

        

        
    }
}
