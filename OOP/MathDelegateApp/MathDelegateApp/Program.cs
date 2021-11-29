using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp
{
    delegate void DMathOperations(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            DMathOperations m1;
            m1 = Add;
            m1 += Subtract;
            m1 += Multiply;
            m1 += Divide;
            m1(5, 3);
            Console.ReadKey();


        }
        public static void Add(int num1,int num2)
        {
            Console.WriteLine("Addition:" + (num1 + num2));
        }

        public static void Subtract(int num1,int num2)
        {
            Console.WriteLine("Subtraction:" + (num1 - num2));
        }

        public static void Multiply(int num1,int num2)
        {
            Console.WriteLine("Multiplication:" + (num1 * num2));
        }

        public static void Divide(int num1,int num2)
        {
            float result = num1 / num2;
            Console.WriteLine("Division:" + result);

        }
        
    }
}
