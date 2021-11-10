using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskSumAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            float avg = 0.0F;
            int i;
            int max = 0;
            for (i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]);
                arr[i] = Convert.ToInt32(args[i]);
            }
            int a = Convert.ToInt32(args[0]);
            for (i = 0; i < args.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of elements:" + sum);
            avg = (float)sum / arr.Length;
            Console.WriteLine("Average of array:" + avg);
            
                for (i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                Console.WriteLine("Maximum no :"+ max);
            }

        }
    }

