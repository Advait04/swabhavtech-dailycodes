using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomAttributeApp.Model
{
    class Foo
    {
        [NeedToRefactor(Name ="m1" )]
        public void M1()
        {
            Console.WriteLine("Method 1");

        }
        public void M2()
        {
            Console.WriteLine("Method 2");

        }
        [NeedToRefactor(Name= "M3")]
         
        public void M3()
        {
            Console.WriteLine("Method 3");

        }
        [NeedToRefactor(Name = "M4")]

        public void M4()
        {
            Console.WriteLine("Method 4");

        }
    }
}
