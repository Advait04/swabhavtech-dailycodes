using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 100;
            Console.WriteLine("Value Before Calling The Function:" + value);
            Multiply(ref value);
            Console.WriteLine("Value After CAlling The Function:" + value);

        }
        public static void Multiply(ref int value)
        {
            value = value * value;
            Console.WriteLine("Value Inside the Function:" + value);
        }
    }
}
