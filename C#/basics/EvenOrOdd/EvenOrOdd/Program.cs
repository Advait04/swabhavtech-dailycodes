using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenOrOdd
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Print Even and Odd Number In Given Range");

            Console.WriteLine("Input the range to print starting from 1");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" All Even Numbers From 1 to {0} are :", number);
            EvenAndOdd(2, number);

            Console.WriteLine("All Odd Numbers From 1 to {0} are :", number);
            EvenAndOdd(1, number);

            return;

        }
   static void GetEven(int val, int number)
        {
            if (val > number)
                return;
            Console.WriteLine(" {0} ", val);
            GetEven(val + 2, number);
        }
        static void GetOdd(int val , int number)
        {
            if (val > number)
                return;
            Console.WriteLine("{0}", val);
            Console.WriteLine(val + 2, number);
        }

    }
}
