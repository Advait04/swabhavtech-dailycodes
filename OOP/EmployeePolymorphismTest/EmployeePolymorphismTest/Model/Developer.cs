using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeePolymorphismTest.Model
{
    class Developer : Employee
    {
       
        public Developer(int empNo, string empName, double bsalary) : base(empNo, empName, bsalary)
        {

        }
        public override void CalculateSalary()
        {
            base.ta = base._basicSalary * 40 / 100;
            base.da = base._basicSalary * 30 / 100;




        }
    }
}
