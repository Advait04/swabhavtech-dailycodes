using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvaitCalcLib
{
   public class Calculator
    {
        public long CubeEvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                return number*number*number;
                  
            }
             return -1;
            
        }
    }
}
