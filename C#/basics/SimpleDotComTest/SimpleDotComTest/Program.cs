using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDotComTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGuess = 0;
            SimpleDotCom dot = new SimpleDotCom();
            int[] locations = { 1, 2, 3 };
            dot.seLocationCells = locations;
            String userGuess = "1";
            String result = dot.checkIt(userGuess);
         
            
        }
    }
    public class SimpleDotCom
    {
        int[] locationCells;
        int numOfHits = 0;


        public void setLocationCells(int[] value)
        {
            {
                locationCells = value;
            }
        }


        public string checkIt(string userGuess)
        {
            int guess = Convert.ToInt32( userGuess);
            string result = "miss";


            foreach (int cell in locationCells) 
            {
                if (guess == cell )
                {
                    result = "HIT";
                    numOfHits++;
                    break;
                }
            }
            if (numOfHits == locationCells.Length)
            {
                result = "KILL";
            }
            Console.WriteLine(result);
            return result;

            
        }

    }




}
