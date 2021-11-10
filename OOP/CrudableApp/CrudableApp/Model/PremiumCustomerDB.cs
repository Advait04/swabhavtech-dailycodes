using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudableApp.Model
{
    class PremiumCustomerDB : CustomerDB
    {
        public override void DeleteFromFile()
        {
            Console.WriteLine("Premium CUstomer Is Deleted");
        }

        public override void UpdateToFile()
        {
            Console.WriteLine("Premium Customer is Updated");
        }
    }
}
