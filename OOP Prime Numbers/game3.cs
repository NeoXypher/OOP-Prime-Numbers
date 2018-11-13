using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Prime_Numbers
{
	class game3
	{
		public static void Task4()
		{
			int playerGuess;
			int score = 0;
			int generatedNumber;
			bool Correct = true;
			do
			{
				Random rnd = new Random();
				generatedNumber = rnd.Next(1, 1001);
				Console.WriteLine(generatedNumber);

				Console.WriteLine("Is this number divisible by 3, 5 or 7? (If none enter 1)");
				playerGuess = Convert.ToInt32(Console.ReadLine());

				scoreCalaculator(playerGuess, generatedNumber, ref Correct);

				scoreCompare(ref score, Correct, playerGuess);
			} while (score < 60 || score > 0);

			if (score >= 60)
				Console.WriteLine("You Win!");
			else
				Console.WriteLine("You Lose!");
			Console.ReadLine();
		}

		public static void scoreCompare(ref int score, bool Correct, int playerGuess)
		{
			if (Correct)
			{
				Console.WriteLine("You guessed correctly!");
				score += playerGuess;
			}
			else
			{
				Console.WriteLine("Wrong answer!");
				score -= 3;
			}
				
		}

		public static void scoreCalaculator(int playerGuess, int generatedNumber, ref bool Correct)
		{
			if ((generatedNumber % playerGuess == 0) && playerGuess != 1)
				Correct = true;
			else
				Correct = false;
		}

	}
}
