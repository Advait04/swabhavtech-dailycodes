using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();
        }
        private static void CaseStudy1()
        {
            Men x;
            x = new Men();
            x.Walk();
            x.Play();
            x.Read();
        }
        private static void CaseStudy2()
        {
            Boy y;
            y = new Boy();
            y.Play();
            y.Jump();
            y.Walk();
            y.Read();
        }
        private static void CaseStudy3()
        {
            Men x;
            x = new Boy();
            x.Read();
            x.Play();
            x.Walk();
        }
        private static void CaseStudy4()
        {
            AtThePark(new Men());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new InFant());
        }
        public static void  AtThePark (Men x) 
             {
            Console.WriteLine("At The Park");
            x.Play();
        }
        private static void CaseStudy5()
        {
            Object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "Hello World";
            Console.WriteLine(x.GetType());
            x = 10.55f;
            Console.WriteLine(x.GetType());
            x = new Men();
            Console.WriteLine(x.GetType());

        }

    }
}
