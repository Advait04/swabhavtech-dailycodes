using HumanEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Advait", 6, 82, GenderType.MALE);
            PrintDetails(h);
            h.Eat();
            PrintDetails(h);
            h.Workout();
            PrintDetails(h);

            Console.Readline();
        }
        private static void PrintDetails(Human h)
        {
            Console.WriteLine("Name is :" + h.GetName());
            Console.WriteLine("Weight is :" + h.GetWeight() + "Kg");
            Console.WriteLine("height is :" + h.GetHeigth() + "Feet");
            Console.WriteLine("Gender is :" + h.GetGender());
            Console.WriteLine();
        }
    }
}
