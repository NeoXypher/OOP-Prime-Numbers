using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Prime_Numbers
{
	class Happy_Number
	{
		public static void Main()

		{
			int givenNumber = 7, total = 0;
			string toString = Convert.ToString(Math.Pow(givenNumber, 2));
			Console.WriteLine("Enter a Number:");
			givenNumber = Convert.ToInt32(Console.ReadLine());
			do
			{
				total = 0;
				for (int i = 0; i < toString.Length; i++)
				{
					total += Convert.ToInt32(Math.Pow(Convert.ToInt32(toString.Substring(i, 1)), 2));
					//Console.WriteLine(total);
				}
				toString = Convert.ToString(total);
			} while (total != 1 && total != 0 && total != 4 && total != 16 && total != 20 && total != 37 && total != 42 && total != 58 && total != 89 && total != 145);

			if (total == 1)
			{
				Console.WriteLine("{0} is a Happy Number", givenNumber);
			}
			else
			{
				Console.WriteLine("{0} is a Not Happy Number", givenNumber);
			}
			
			Console.ReadLine();
		}
		
	}
}
