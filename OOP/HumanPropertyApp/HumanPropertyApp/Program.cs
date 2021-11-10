using HumanPropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanPropertyApp
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

            Console.ReadLine();
        }
        private static void PrintDetails(Human h)
        {
            Console.WriteLine("Name is :" + h.Name);
            Console.WriteLine("Weight is :" + h.Weight + "Kg");
            Console.WriteLine("height is :" + h.Heigth + "Feet");
            Console.WriteLine("Gender is :" + h.Gender);
            Console.WriteLine();
        }
    }
}