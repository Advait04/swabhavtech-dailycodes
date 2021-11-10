using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassByValueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 100;
            Console.WriteLine("Varaible Value Before Calling the Method:" + X);
            AddNum(X);
            Console.Write("Variable value after calling the method:" + X);
            Console.Read();
        }
        public static void AddNum(int number)
        {
            number = number + 5;
            Console.WriteLine("VAriable Value Inside Method:" + number);
        }
    }
}
