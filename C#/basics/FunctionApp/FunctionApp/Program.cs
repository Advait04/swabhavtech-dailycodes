using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 20, 30, 40, 50 };
            int large = num.Length;
            Program p = new Program();
            Console.WriteLine(PrintLargest(num, large));
            p.PrintSumOf(num);
            p.PrintAvg(num);

        }

        float avg;
        static int PrintLargest(int[] num, int large)
        {
            return num.Max();

        }

        void PrintSumOf(int[] num)
        {

          int sum = num.Sum();

            Console.WriteLine("Sum :" + sum);

        }

        void PrintAvg(int[] num)
        {
           
            int sum = 0;
            avg = (float)sum / num.Length;
            Console.WriteLine("Average : " + avg);

        }
    }
}