using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingletonPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>

            {
                DataService.GetInstance().DoSomething();
            });

            Thread t2 = new Thread(() =>
            {
                DataService.GetInstance().DoSomething();
            });
            t1.Start();
            t2.Start();

            Console.ReadKey();


        }
        public static void CaseStudy1()
        {
            var service1 = DataService.GetInstance();
            var service2 = DataService.GetInstance();
            Console.WriteLine(service1.GetHashCode());
            Console.WriteLine(service2.GetHashCode());

            service1.DoSomething();
            service2.DoSomething();
            Console.ReadKey();
        }
    }
}

