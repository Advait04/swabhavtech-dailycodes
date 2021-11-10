using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            student s1 = new student();
            s1.SetId(9911);
            Console.WriteLine("Student Id :" + s1.GetId());
            

                
            s1.SetName("Advait");
            s1.SetCgpa(6.75);
            Console.ReadLine();

            
          
            
            
        }

        
           
        }
    }


