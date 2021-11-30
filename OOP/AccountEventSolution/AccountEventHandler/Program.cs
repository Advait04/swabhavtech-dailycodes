using AccountEventLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Advait", 101, 20000);
            account1.OnBalanceChanged += PrintDetails;
            account1.Deposit(2000);
            account1.Withdraw(1000);
            Console.ReadKey();
        }
        public static void PrintDetails(Account account)
        {
            Console.WriteLine("\nAccount Details: ");
            Console.WriteLine("Name: {0}\nId: {1}\nBalance: {2}", account.GetName(), account.GetAccountNumber(), account.GetBalance());
        }
    }
}

