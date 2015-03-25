using System;

namespace FizzBuzz2
{
	public class GameClass
	{
		private string shout;

		public static void Main(string[] arg)
		{
			GameClass obj = new GameClass ();
			Console.WriteLine ("Enter a Number: ");
			string numberString = Console.ReadLine ();
			int number = int.Parse (numberString);
			obj.DivisibleBy3 (number);
			obj.DivisibleBy5 (number);
			obj.DivisibleBy15 (number);
			Console.WriteLine (obj.Shout);
		}

		public void DivisibleBy15(int number)
		{
			if (number  % 15 == 0) {
				shout = "FizzBuzz";
			} 
		}

		public void DivisibleBy3(int number)
		{
			if (number  % 3 == 0) {
				shout = "Fizz";
			} 
		}

		public void DivisibleBy5(int number)
		{
			if (number  % 5 == 0) {
				shout = "Buzz";
			} 
		}

		public string Shout
		{
			get { return shout; }
		}
	}
}
