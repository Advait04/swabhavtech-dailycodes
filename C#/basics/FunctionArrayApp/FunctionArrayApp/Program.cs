using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionArrayApp
{
    class Program
    {

        static void UpdateMarkToZero(int mark)
        {
            mark = 0;
            Console.WriteLine("MArks:" + mark);
        }
        static void UpdateAllMarksToZero(int[] marks)
        {
            int temp = 0;
            Console.WriteLine(marks.GetHashCode());
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = 0;
            }
        }
        static void Main(string[] args)
        {
            int mark = 100;

            UpdateMarkToZero(mark);
            Console.WriteLine(mark);
            int[] marks = { 10, 20, 30, 40, 50 };
            UpdateAllMarksToZero(marks);           
            foreach (int temp in marks)
            {
                Console.WriteLine(temp);
            }

        }
    }
}

