using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollegeApp
{
    class Student
    {
        private string _branch;
        public Student (string branch,int id,string address,string dob) : base (id,address,dob)
        {
            _branch = branch;
        }
        public string Branch
        {
            get
            {
                return _branch;
            }
        }
    }
}
