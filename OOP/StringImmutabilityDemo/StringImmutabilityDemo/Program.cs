using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringImmutabilityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Rohit";
            string str2 = "Rohit";
            Console.WriteLine("Initial Hash Code");
            Console.WriteLine("String 1 HashCode:" + str1.GetHashCode());
            Console.WriteLine("String 2 HashCode:" + str2.GetHashCode());

             str2 = "Virat";
            Console.WriteLine("After Changing Value Hash Codes");
            Console.WriteLine("String 1 HashCode:" + str1.GetHashCode());
            Console.WriteLine("String 2 HashCode:" + str2.GetHashCode());

            string str3 = "Rahul";
            Console.WriteLine("After Introducing 3 Variable Hash Codes");
            Console.WriteLine("String 1 HashCode:" + str1.GetHashCode());
            Console.WriteLine("String 2 HashCode:" + str2.GetHashCode());
            Console.WriteLine("String 3 Hashcode:" + str3.GetHashCode());

            Console.ReadLine();


        }
    }
}
