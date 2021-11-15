using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeePolymorphismTest.Model
{
    class Accountant : Employee 
    {
        
      
        public Accountant (int empNo, string empName, double bsalary) : base(empNo, empName, bsalary)
        {

        }
        public  override void CalculateSalary()
        {
            perks = (_basicSalary * 30) / 100;
        }
    }
}
