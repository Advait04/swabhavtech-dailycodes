using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudableApp.Model
{
    class OrderDb : ICrudable
    {
        public void CreateAFile()
        {
            Console.WriteLine("Order is getting Added");
        }

        public void DeleteFromFile()
        {
            Console.WriteLine("Order is getting Deleted");
        }

        public void ReadFromFile()
        {
            Console.WriteLine("Reading From File");
        }

        public void UpdateToFile()
        {
            Console.WriteLine("Updating to File");
        }
    }
}
