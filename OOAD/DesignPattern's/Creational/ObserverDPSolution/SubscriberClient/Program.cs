
using PublisherLib.Publisher;
using SubscriberClient.Susbscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Advait", "ak@gmail.com", 101, 5000);
            account1.AddNotifier(new SmsNotifier());
            account1.AddNotifier(new EmailNotifier());
            account1.Deposit(100);
            Console.ReadKey();
        }
    }
}
