using System;

namespace PullPuzzleTest
{
    class Program
    {
        static void Main(string[] args)

        {
            int x = 0;
            while (x < 4)
            {
                Console.WriteLine("a");
                if (x < 1)
                {
                    Console.WriteLine(" ");
                }
                Console.WriteLine("n");
                if (x > 1)
                {
                    Console.WriteLine("oyster");
                    x = x + 2;
                }
                if (x == 1)
                {
                    Console.WriteLine("noys");
                }
                if (x < 1)
                {
                    Console.WriteLine("oise");
                }
                Console.WriteLine(" ");
                x = x + 1;

            }
        }
    }
}


