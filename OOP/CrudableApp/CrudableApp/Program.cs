using CrudableApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new ProductDB());
            DoDbOperations(new OrderDb());
            Console.ReadLine();
        }

        public static void DoDbOperations(ICrudable obj)
        {
            Console.WriteLine("All the Operations Are Performed");
            obj.CreateAFile();
            obj.DeleteFromFile();
            obj.ReadFromFile();
            obj.UpdateToFile();

        }
    }
}
