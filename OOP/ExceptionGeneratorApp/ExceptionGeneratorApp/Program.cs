using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum = Convert.ToInt32(args[0]);
            int secondnum = Convert.ToInt32(args[1]);
            int result = firstNum / secondnum;

            Console.WriteLine("{0},{1},{2}", firstNum, secondnum, result);
            Console.WriteLine("End Of Main");

          
           
        }
    }
}

