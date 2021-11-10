using SetGenericApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }
        public static void CaseStudy1()
        {
            HashSet<int> nos = new HashSet<int>();
            nos.Add(10);
            nos.Add(200);
            nos.Add(5);
            nos.Add(5);
            nos.Add(300);
            Console.WriteLine("Count"+nos.Count());
            foreach(int item in nos)
            {
                Console.WriteLine(item);
            }


        }
        public static void CaseStudy2()
        {
            Student s1 = new Student(101, "Advait", "Mumbai");
            Student s2 = new Student(101, "Advait", "Mumbai");
            Student s3 = new Student(101, "Advait", "Mumbai");
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            HashSet<Student> students = new HashSet<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            Console.WriteLine(students.Count());

        }
    }
}
