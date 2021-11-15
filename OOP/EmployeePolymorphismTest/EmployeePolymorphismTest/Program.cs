using EmployeePolymorphismTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeePolymorphismTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer d1 = new Developer(101, "Advait", 100000);
            d1.CalculateSalary();
            SalarySlip(d1);
            Manager m1 = new Manager(102, "Rohit", 200000);
            m1.CalculateSalary();
            SalarySlip(m1);
            Accountant a1 = new Accountant(103, "Virat", 30000);
            a1.CalculateSalary();
            SalarySlip(a1);

            Console.ReadLine();
        }
        public static void SalarySlip(Employee em1)
        {
            Console.WriteLine("__________SALARY SLIP__________");
            Console.WriteLine("Employee Post:" + em1.GetType().Name);
            Console.WriteLine("Employee No:" + em1.empNo);
            Console.WriteLine("Employee Name:" + em1.empName);
            Console.WriteLine("employee Basic Salary:" + em1.basicSalary);
            Console.WriteLine("Employee HRA :" + em1.hra);
            Console.WriteLine("Employee DA:" + em1.da);
            Console.WriteLine("Employee TA:" + em1.ta);
            Console.WriteLine("Employee Perks:" + em1.perks);
        }
    }
}
