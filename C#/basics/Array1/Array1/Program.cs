using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, max;
            int[] arr = new int[5];

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter elements");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            for (i = 1; i < 5; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Maximum elements is :" + max);
        }
    }
}
