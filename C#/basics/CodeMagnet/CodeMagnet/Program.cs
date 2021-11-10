using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeMagnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            while (x > 0)
            {
                if (x > 2)
                {
                    Console.WriteLine("a");
                }
                x = x - 1;
                Console.WriteLine("-");

                if (x == 2)
                {
                    Console.WriteLine("b c");
                }
                if (x == 1)
                {
                    Console.WriteLine("d");
                    x = x - 1;
                }

            }
        }
    }
}

