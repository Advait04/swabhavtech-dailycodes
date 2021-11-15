using System;

namespace CustomerID
{
    class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer("Advait", 10000);
            customer c2 = new customer("vinod", 12000);
            customer c3 = new customer("vivek", 13000);
            PrintDetails(c1);
            PrintDetails(c2);
            PrintDetails(c3);



            Console.ReadLine();
        }

        private static void PrintDetails(customer c1)
        {
            Console.WriteLine("customer id: " + c1._id);
            Console.WriteLine("customer name: " + c1.GetCustomerName());
            Console.WriteLine("customer Salary: " + c1.GetCustomerSalary());


        }
    }
}
        }
    }
}
