using SetGenericApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDictApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        public static void CaseStudy1()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "ONE");
            map.Add(1, "One");
            map.Add(2, "TWO");

            Console.WriteLine(map.Count);

            foreach (KeyValuePair<int,string> pair in map)
            {
                Console.WriteLine("Keys:{0},value:{1}");
            }
        }
        public static void CaseStudy2()
        {
            var map = new Dictionary<Student,Student>();

            var s1 = new Student(12, 10, "Advait", "Mumbai");
            var s2 = new Student(10, 12, "Rohit", "Mumbai");
            var s3= new Student(12, 10, "ADVAIT", "MUMBAi");

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            map.Add(s1, s1);
            map.Add(s2, s2);
            if(map.Contains(s3))
            {
                map.Add(s3, s3);
            }
            Console.WriteLine("MapCount:" + map.Count());
        }
    }
}
