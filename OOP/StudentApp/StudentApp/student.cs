using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApp
{
    class student
    {
        private double cgpa,id;
        private double percentage;
        private string name,grade;
        

        public void SetName(string pname)
        {
            name = pname;

        }
        private  string GetName()
        {
            return name;
        }

        public void SetId(int pid)
        {
            id = pid;
        }

        private double GetId()
        {
            return id;
        }
         
        public void SetCgpa(double pcgpa)
        {
            cgpa = pcgpa;
            
        }

        private double GetCgpa()
        {
            return cgpa;
        }


        
        private   double CalculatePercentage()
        {
            percentage = cgpa*10;
            return percentage;

        }

        private void AssignGrade()
        {
            if(percentage > 75)
            {
                grade = "A";

            }
            else if(percentage > 60)
            {
                grade = "B";
            }
            else if (percentage > 50)
            {
                grade = "C";
            }
            else if (percentage >= 40)
            {
                grade = "D";
            }
            else
            {
                Console.WriteLine("Invalid Percentage");
            }
            
        }


    }
}
