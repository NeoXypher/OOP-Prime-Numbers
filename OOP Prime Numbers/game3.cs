using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Prime_Numbers
{
	class game3
	{
		public static void Main()
		{
			char playerGuess;
			int score = 0;
			int generatedNumber;
			bool Correct = true;
			do
			{
				Random rnd = new Random();
				generatedNumber = rnd.Next(1, 1001);
				Console.WriteLine(generatedNumber);

				Console.WriteLine("Is this number divisible by 3? Y/N");
				playerGuess = Convert.ToChar(Console.ReadLine());

				scoreCalaculator(playerGuess, generatedNumber, ref Correct);

				scoreCompare(ref score, Correct);
			} while (score < 6 || score > 0);

			if (score >= 6)
				Console.WriteLine("You Win!");
			else
				Console.WriteLine("You Lose!");
			Console.ReadLine();
		}

		public static void scoreCompare(ref int score, bool Correct)
		{
			if (Correct)
			{
				Console.WriteLine("You guessed correctly!");
				score += 3;
			}
			else
			{
				Console.WriteLine("Wrong answer!");
				score -= 3;
			}
				
		}		public static void scoreCalaculator(char playerGuess, int generatedNumber, ref bool Correct)
		{
			if ((generatedNumber % 3 == 0 && playerGuess == Convert.ToChar("Y")) || (generatedNumber % 3 != 0 && playerGuess == Convert.ToChar("N")))
				Correct = true;
			else
				Correct = false;
		}
	}
}
