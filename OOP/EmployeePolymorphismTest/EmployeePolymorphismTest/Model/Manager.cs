using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeePolymorphismTest.Model
{
    class Manager : Employee
    {



        public Manager(int empNo, string empName, double bsalary) : base(empNo, empName, bsalary)
        {

        }
        public override void CalculateSalary()
        {
            base.hra = (_basicSalary * 50) / 100;
            base.ta = (_basicSalary * 40) / 100;
            base.da = (_basicSalary * 30) / 100;



        }

    }
}
