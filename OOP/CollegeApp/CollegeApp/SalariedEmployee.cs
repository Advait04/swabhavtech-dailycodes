using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollegeApp
{
    
        abstract class SalariedEmployee : Person
        {
            protected float _basicSalary;

            public SalariedEmployee(int id, string address, string dob) : base(id, address, dob)
            {
                _basicSalary = 300000;
            }
            public abstract float CalculateSalary();
        }
}
