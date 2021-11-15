using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLineArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);
            
            for(int i = 0; i < a; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
