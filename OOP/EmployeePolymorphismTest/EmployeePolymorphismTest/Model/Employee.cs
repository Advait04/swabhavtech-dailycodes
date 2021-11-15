using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeePolymorphismTest.Model
{
    
    abstract class Employee
    {
         int _empNo;
         string _empName;
        protected double _basicSalary;
        public double hra;
        public double ta;
        public double da;
        public double perks;
        public Employee(int empNo ,string empName,double bsalary)
        {
            _empNo = empNo;
            _empName = empName;
            _basicSalary = bsalary;
        }
        public abstract void CalculateSalary();
        
        
        public int empNo
        {
            get
            {
                return _empNo;
            }
        }
        public string empName
        {
            get
            {
                return _empName;
            }
        }
        public double basicSalary
        {
            get
            {
                return _basicSalary;
            }
        }
    }
}
