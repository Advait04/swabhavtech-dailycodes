using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Function1App
{
    class Program
    {
        float average;
        static int PrintLargest(int[] num,int large)
        {
            return num.Max();
        }

        void PrintSumOF(int[] num)
        {
            for(int i = 0;i < num.Length; i++ )
            {
                int sum = 0;
                
                Console.WriteLine(" Sum :" + sum);
            }
        }
        void PrintAverage(int[] num)
        {
            int sum = 0;
            average = (float)sum / num.Length;
            Console.WriteLine("Average:" + average);
        }
        static void Main(string[] args)
        {
            int num = { 10, 20, 30, 40, 50 };
            int large = num.Length;
            Program a = new Program();
            Console.WriteLine(PrintLargest(num, large));
            a.PrintSumOF(num);
            a.PrintAverage(num);

        }
    }
}
