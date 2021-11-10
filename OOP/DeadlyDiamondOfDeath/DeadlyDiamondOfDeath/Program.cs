using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeadlyDiamondOfDeath
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class A
    {
        public A()
        {
            Console.WriteLine("Base A Class Constructor Invoked");
        }

    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("Child B Class Constuctor Invoked");
        }

    }
    class C: A
    {
        public C()
        {
            Console.WriteLine("Child C Class Constructor Invoked");
        }

    }
    class D : B, C
    {
        public D()
        {
            Console.WriteLine("Child D Class Constructor Invoked");
        }
    }
}
