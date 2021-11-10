using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigGameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRoll = 0;

            int playerRoundTotal;

            int playerGamePts = 0;

            int nextPlayer = 0;
            int hold, roll;
            Random numberGenerator = new Random();
            Console.WriteLine("Pig Dice Game");
            Console.WriteLine();
            Console.ReadKey();

            while (playerGamePts < 20)
            {
                playerRoundTotal = 0;
                while (true)
                {
                    playerRoll = numberGenerator.Next(1, 7);
                    Console.WriteLine("Your Roll Is :" + playerRoll);
                    playerRoundTotal += playerRoll;

                    if (playerRoll == 1)
                    {
                        playerRoundTotal = 0;
                        break;
                        Console.WriteLine("Player 1 total points for this round is" + playerRoundTotal + "Would you like to continue");
                        
                    }
                    else
                    {
                        Console.WriteLine("Roll or Hold");
                        nextPlayer = Convert.ToChar(Console.ReadLine());
                       
                        if (nextPlayer == hold)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    playerGamePts += playerRoundTotal;
                    Console.WriteLine("Player 1 total points for this round is:" + playerRoundTotal + "and for the gane is:" + playerGamePts + ".");


                }

            }




            Console.WriteLine("GAME OVER !!!");
            Console.WriteLine(".");
            Console.WriteLine("Player 1 Total Point for this game is :" + playerOneGamePts + ".");



        }

    }
}


