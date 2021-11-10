using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerilizationExp1Test.Model
{
    [Serializable]
    class Person
    {
        private string _name;
        private string _lastname; 

        public Person(string name,string lastname)
        {
            this._name = name;
            this._lastname = lastname;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
         
        public string LastName
        {
            get
            {
                return _lastname;
            }
        }
 
      
    }
}
