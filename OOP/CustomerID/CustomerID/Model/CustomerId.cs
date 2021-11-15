using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerID.Model
{
    class CustomerId
    {
        public string _id;
        string _name;
        int _salary;
        static int count = 1000;

        public customerId(string pname, int psalary)
        {
            _name = pname;
            _salary = psalary;
            _id = "c" + count.ToString();
            count++;
        }
        public string GetCustomerName()
        {
            return _name;
        }
        public int GetCustomerSalary()
        {
            return _salary;
        }

    }
}
    }
}
