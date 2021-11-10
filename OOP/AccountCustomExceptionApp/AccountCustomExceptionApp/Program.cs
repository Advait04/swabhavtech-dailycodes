using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountCustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101, "Advait", 1500);
            try
            {
                account.Withdraw(4501);
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Will Execute No Matter");
                PrintDetails(account);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("End Of Main");

           
        }
        public static void PrintDetails(Account account)
        {
            Console.WriteLine("Account No :" + account.GetAccNo());
            Console.WriteLine("Account Holder's NAme :" + account.GetName());
            Console.WriteLine("Account Balance:" + account.GetBalance());
            Console.WriteLine();
        }
    }
}
