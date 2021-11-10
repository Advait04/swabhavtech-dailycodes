using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessGameFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int min = 1;
            int max = 100;
            bool tryAgain = true;
            while(true)
            {
                Console.WriteLine("Game Developed By Advait,copyright @ 2021");
                int randomNumber = rand.Next(min, max + 1);
                int count = 1;
                while(true)
                {
                    Console.WriteLine("Guess Number :" + min + "-" + max + ":");
                    int userGuess = Convert.ToInt32(Console.ReadLine());

                    if(userGuess > randomNumber)
                    {
                        Console.WriteLine(userGuess + "Sorry To High");
                        ++count;
                        continue;
                    }
                    else if (userGuess < randomNumber)
                    {
                        Console.WriteLine(userGuess + "Sorry ,Too Low");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Number:" + randomNumber);
                        Console.WriteLine("You Won");
                        Console.WriteLine("Number Of Guess Taken :" + count);
                        Console.WriteLine("Would You Like To Play Again (1/2)");
                        string playAgain = Console.ReadLine();
                        Console.WriteLine("Thank You !! for using my application, please contact me Advait@aurionpro.com");

                        if (playAgain != "1") ;
                        {
                            tryAgain = false;
                        }
                        break;
                    }
                }
                if (tryAgain) break;
            }
        }
    }
}
