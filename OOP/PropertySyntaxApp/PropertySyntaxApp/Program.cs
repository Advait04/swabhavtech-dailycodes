using PropertySyntaxApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertySyntaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo();
            f.Bar = 100;
            Console.WriteLine(f.Bar);
        }
    }
}
