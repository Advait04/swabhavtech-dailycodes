using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SecurityService service = new SecurityService();
                PrintDetails(service.Login("101", "@101"));
            }
            catch (InvalidUserException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();

        }
        public static void PrintDetails(User user)
        {
            Console.WriteLine("Name: {0} {1}\nID: {2}\nEmail: {3}", user.FirstName, user.LastName, user.ID, user.Email);
        }
    }
}
 

