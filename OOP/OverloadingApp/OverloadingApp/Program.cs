using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadingApp
{
    class Program
    {
        static void Main(String[] args)
        {
            PrintInfo("Advait");
            PrintInfo(100);
            PrintInfo(10.5);
            PrintInfo(10.5f);
            PrintInfo(true);
            PrintInfo('#');
        }
        static void PrintInfo(String s)
        {
            Console.WriteLine(" Overload 1 (String)");
            Console.WriteLine(s);

        }
        static void PrintInfo(int i)
        {
            Console.WriteLine("Overload 2 (Integer)");
            Console.WriteLine(i);
        }
        static void PrintInfo(double d)
        {
        Console.WriteLine("Overload 3 (Double)");
            Console.WriteLine(d);
        }
    static void PrintInfo(float f)
        {
            Console.WriteLine("Overload 4 (Float)");
            Console.WriteLine(f);
        }

     static void PrintInfo(bool b)
        {
           Console.Write("Overload 5 (Boolean)");
           Console.WriteLine(b);
        }

     static void PrintInfo(Char c)
        {
            Console.WriteLine("Overload 6 (charachter)");
            Console.WriteLine(c);
         }

}
    

}

