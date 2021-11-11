using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollegeApp
{
    class Person
    {
        private int _id;
        private string _address;
        private string _dob;

        public Person(int id, string address, string dob)
        {
            _id = id;
            _address = address;
            _dob = dob;
        }
        public int Id
        {
            get { return _id; }
        }
        public string Address 
        { 
            get 
            { 
                return _address;
            } 
        }
        public string Dob
        {
            get
            { 
                return _dob;
            } 
        }
    }
}

