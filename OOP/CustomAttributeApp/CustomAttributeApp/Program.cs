using CustomAttributeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CustomAttributeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAnnotation(typeof(Foo));
        }

        public static void GetAnnotation(Type t)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().Where(T => t.GetCustomAttributes<NeedToRefactor>().Count() > 0);

            var methods = t.GetMethods().Where(m => m.GetCustomAttributes<NeedToRefactor>().Count() > 0);

            Console.WriteLine("Number of Methods Annoted :{0}", methods.Count());
            foreach(var m in methods )
            {
                Console.WriteLine(m.ReturnType.Name + "" + m.Name);

            }
            Console.ReadLine();

        }
    }
}
