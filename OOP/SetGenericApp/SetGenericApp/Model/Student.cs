using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGenericApp.Model
{
    class Student
    {
        public int rollno;
        public string name;
        public string location;

        public Student(int prollno,string pname,string plocations)
        {
            this.rollno = prollno;
            this.name = pname;
            this.location = plocations;
        }
       
        public override int GetHashCode()
        {
            return rollno;
        }
        public override bool Equals(object obj)
        {
            Student studentobj = (Student)obj;
            if (this.rollno == studentobj.rollno) return true;
            return false;
        }

    }
}
