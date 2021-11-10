using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotComScTest
{
    class Program
    {
        static void LocationCells (int[] locs)
        {
            int[] locationCells;
            locationCells = locs;
        }

        static void userInput(string prompt)
        {
            string inputline = null;
            Console.WriteLine(prompt + " ");
            try
            {
                inputline = Console.ReadLine();
                if(inputline.Length == 0)
                {

                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine("IOException:" + e);
            }
        }
        static void Main(string[] args)
        {
            int[] locationCells = { 2, 3, 4 };
            int numOfHits = 0;

            int guess = Convert.ToInt32
        }
    }
}
