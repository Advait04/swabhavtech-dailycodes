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
            int playerOneRoll = 0;
            int playerTwoRoll = 0;
            int playerOneRoundTotal;
            int playerTwoRoundTotal;
            int playerOneGamePts = 0;
            int playerTwoGamePts = 0;
            int nextPlayer = 0;
            Random numberGenerator = new Random();
            Console.WriteLine("Pig Dice Game");
            Console.WriteLine();
            Console.ReadKey();

            while (playerOneGamePts < 50 && playerTwoGamePts < 50)
            {
                playerOneRoundTotal = 0;
                while(true)
                {
                    playerOneRoll = numberGenerator.Next(1, 7);
                    Console.WriteLine("Your Roll Is :" + playerOneRoll);
                    playerOneRoundTotal += playerOneRoll;

                    if(playerOneRoll == 1)
                    {
                        playerOneRoundTotal = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Player 1 total points for this round is" + playerOneRoundTotal + "Would you like to continue");
                        Console.WriteLine("Press any number to continue,or 999 to exit Followed by enter");
                        nextPlayer = Convert.ToInt32(Console.ReadLine());
                        if(nextPlayer == 999)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                playerOneGamePts += playerOneRoundTotal;
                Console.WriteLine("Player 1 total points for this round is:" + playerOneRoundTotal + "and for the gane is:" + playerOneGamePts + ".");
                Console.WriteLine("Now its Player 2 Chance");
                Console.WriteLine("");
                Console.WriteLine("PLayer Two");

                playerTwoRoundTotal = 0;
                while(true)
                {
                    playerTwoRoll = numberGenerator.Next(1, 7);
                    Console.WriteLine("Your Roll Is :" + playerTwoRoll);
                    playerOneRoundTotal += playerTwoRoll;

                    if(playerTwoRoll ==1)
                    {
                        playerTwoRoundTotal = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Player 2 Total Points for this round is :" + playerTwoRoundTotal + "Would You like to continue?");
                        Console.WriteLine("Press any number to continue or 999 to exit");
                        nextPlayer = Convert.ToInt32(Console.ReadLine());
                        if (nextPlayer == 999)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                playerTwoGamePts += playerTwoRoundTotal;
                Console.WriteLine("Player 2 total points for this round is :" + playerTwoRoundTotal + "and for the game is:" + playerTwoGamePts + ".");
                Console.WriteLine("Time For player 1 to see what it takes");
                Console.WriteLine("");
                Console.WriteLine("Player One");

            }
            Console.WriteLine("GAME OVER !!!");
            Console.WriteLine("");
            Console.WriteLine("Player 1 Total Point for this game is :" + playerOneGamePts + ".");
            Console.WriteLine("PLayer 2 Total Point For this game is" + playerTwoGamePts + ".");


        }
    }
}
