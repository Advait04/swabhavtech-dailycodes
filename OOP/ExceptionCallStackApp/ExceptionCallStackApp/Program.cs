using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionCallStackApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                M1();
            }
            catch (Exception )
            {
                Console.WriteLine("End Of Main..");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
        
         
      private static  void M1()
        {
            Console.WriteLine("Inside M1");
            M2();
        }
        private static void M2()
        {
            Console.WriteLine("Inside M2");
            M3();
        }
        private static void M3()
        {
            Console.WriteLine("Inside M3");
            throw new Exception("Something Went Wrong In M3 !! ");
            
        }
        
    }
}
