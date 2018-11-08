using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Prime_Numbers
{
	class Program
	{
		
		public static void Task3()
		{
			int h = 4, w = 3;
			WriteRectangle(h, w);
			Console.ReadLine();
		}

		public static void Old()
		{
			int number, raised;
			bool result;
			Fibonacci Fib = new Fibonacci();
			number = Fib.Solve();
			Console.WriteLine(number);
			numericalFunc Function = new numericalFunc();
			Console.WriteLine("Enter a number:");
			number = Convert.ToInt32(Console.ReadLine());
			result = Function.PrimeTest(number);
			if (result)
				Console.WriteLine("Number is prime.");
			else
				Console.WriteLine("Number is not prime");
			Console.WriteLine("Enter a number to raised to the power of: ");
			raised = Convert.ToInt32(Console.ReadLine());
			number = Function.Power(number, raised);
			Console.WriteLine("Result: {0}", number);
			Console.ReadLine();
		}

		public static void Task1()
		{
			Program NewObj = new Program();
			SayHello("John");
			NewObj.SayGoodbye();
		}

		public static void Task2()
		{
			int x;
			x = Convert.ToInt32(Console.ReadLine());
			Double(ref x);
			Console.WriteLine(x);
			Console.ReadLine();
		}

		public static void SayHello(string name)
		{
			Console.WriteLine("Hello, {0}", name);
		}

		public void SayGoodbye()
		{
			Console.WriteLine("Goodbye");
		}

		public static void Double(ref int x)
		{
			x *= 2;
		}

		public static void WriteRectangle(int h, int w)
		{
			for (int i = 0; i < h; i++)
			{
				for (int i2 = 0; i2 < w; i2++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}

	class numericalFunc
	{
		public bool PrimeTest(int number)
		{
			bool result = true;
			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
					result = false;
			}
			return result;
		}

		public int Power(int number, int raised)
		{
			int result = number;
			for (int i = 1; i < raised; i++)
			{
				result = result * number;
			}
			return result;
		}
	}

	class Fibonacci
	{
		public int Solve()
		{
			int result = 2, n1 = 1, n2 = 2, n3 = 0;
			do
			{
				n3 = n1 + n2;
				if (n3 % 2 == 0)
					result += n3;
				n1 = n2;
				n2 = n3;
			} while (n2 < 4000000);
			return result;
		}
	}	
}
