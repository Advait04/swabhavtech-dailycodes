using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudableApp.Model
{
    class ProductDB : ICrudable
    {
        public void CreateAFile()
        {
            Console.WriteLine("Product Is Created");
        }

        public void DeleteFromFile()
        {
            Console.WriteLine("Product is Deleted");
        }

        public void ReadFromFile()
        {
            Console.WriteLine("Reading From File");
        }

        public void UpdateToFile()
        {
            Console.WriteLine("Updating To File");
        }
    }
}
