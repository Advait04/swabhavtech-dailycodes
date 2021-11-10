using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudableApp.Model
{
    abstract class CustomerDB : ICrudable
    {
        public void CreateAFile()
        {
            Console.WriteLine("Customer Is Created");
        }

        public abstract void DeleteFromFile();



        public void ReadFromFile()
        {
            Console.WriteLine("Reading From File");
        }

        public abstract void UpdateToFile();
        
    }
}
