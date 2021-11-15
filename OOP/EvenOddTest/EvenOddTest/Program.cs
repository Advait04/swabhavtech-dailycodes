using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenOddTest
{
    class Program
    {
     

       public  void isEven(int value)
            if (value % 2 == 0)
                    {

            Console.WriteLine("{0}", value);
            return;
            
           
         }

       public  void isOdd(int value)
        {
            if (value % 2 != 0)
                
            Console.WriteLine("{0}", value);
            return;
                
            
            
            
        }
       static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Input the range to print even and odd number in given range");
            number = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();
            p.isOdd();
            p.isEven();
            Console.ReadLine();



        }
    }
}
