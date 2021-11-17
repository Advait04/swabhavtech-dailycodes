using PublisherLib;
using PublisherLib.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberClient.Susbscriber
{
   public class SmsNotifier:INotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Sms sent to AccountNumber", account.GetAccNo());
        }

      
    }
}
