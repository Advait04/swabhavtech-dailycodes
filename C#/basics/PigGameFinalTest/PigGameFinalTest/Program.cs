using System;
using System.IO;

namespace Pig
{

	class Roll
	{
		public int TotalScore { get; set; }
		public int RollScore { get; set; }
		public bool Continue { get; set; }
	}

	class Player
	{
		public String Name { get; set; }
		public int Score { get; set; }
		Random rand;

		public Player()
		{
			Score = 0;
			rand = new Random();
		}

		public Roll Roll(int LastScore)
		{
			Roll roll = new Roll();
			roll.RollScore = rand.Next(6) + 1;

			if (roll.RollScore == 1)
			{
				roll.TotalScore = 0;
				roll.Continue = false;
				return roll;
			}

			roll.TotalScore = LastScore + roll.RollScore;
			roll.Continue = true;
			return roll;
		}

		public void FinalizeTurn(Roll roll)
		{
			Score = Score + roll.TotalScore;
		}
	}

	public class Game
	{
		public static void Main(String[] argv)
		{
			String input = null;
			Player[] players = new Player[1];

			// Game loop
			while (true)
			{ 
				Console.Write("Greetings! Would you like to play a game (y/n)?");
				while (input == null)
				{
					input = Console.ReadLine();
					if (input.ToLowerInvariant() == "y")
					{
						players[0] = new Player();
						
						Console.Write(" what's your name?");
						input = Console.ReadLine();
						players[0].Name = input;
						
						
						
					}
					else if (input.ToLowerInvariant() == "n")
					{
						goto Goodbye; 
					}
					else
					{
						input = null;
						Console.Write("I'm sorry, I don't understand. Play a game (y/n)?");
					}
				}

				
				int currentPlayer = 0;
				Roll roll = null;
				bool runTurn = true;
				while (runTurn)
				{
					Player p = players[currentPlayer];
					roll = p.Roll((roll != null) ? roll.TotalScore : 0);
					if (roll.Continue)
					{
						if (roll.TotalScore + p.Score > 20)
						{
							Console.WriteLine("Congratulations, " + p.Name + "! You rolled a " + roll.RollScore + " for a final score of " + (roll.TotalScore + p.Score) + "!");
							runTurn = false;
						}
						else
						{
							Console.Write(p.Name + ": Roll " + roll.RollScore + "/Turn " + roll.TotalScore + "/Total " + (roll.TotalScore + p.Score) + ". Roll or Hold(R/H):");
							input = Console.ReadLine();
							if (input.ToLowerInvariant() == "R")
							{
								
							}
							else if (input.ToLowerInvariant() == "H")
							{
								p.FinalizeTurn(roll);
								currentPlayer = Math.Abs(currentPlayer - 1);
								Console.WriteLine();
								Console.WriteLine(players[0].Name + ": " + players[0].Score );
								Console.WriteLine(players[currentPlayer].Name + ", your turn begins.");
								roll = null;
							}
							else
							{
								input = null;
								
							}
						}
					}
					else
					{
						Console.WriteLine(p.Name + @", you rolled a 1 and lost your points for this turn.
Your current score:	" + p.Score);
						Console.WriteLine();
						Console.WriteLine(players[0].Name + ": " + players[0].Score );
						currentPlayer = Math.Abs(currentPlayer - 1);
					}
				}


				input = null;
			}
			Goodbye:
			Console.WriteLine("Thanks for playing");
			System.Environment.Exit(0);
		}
	}
}