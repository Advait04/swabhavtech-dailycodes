using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers:");

            for (int i = 0; i < args.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(args[i]);
                }
            }
            Console.WriteLine();
        }

    }
}