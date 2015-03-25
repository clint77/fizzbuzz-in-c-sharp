namespace FizzBuzz2
{
	using NUnit.Framework;

	[TestFixture]
	public class GameClassTest
	{
		[Test]
		public void DivisibleBy15()
		{
			GameClass numberFizzBuzz = new GameClass();
			numberFizzBuzz.DivisibleBy15 (15);
			Assert.AreEqual("FizzBuzz", numberFizzBuzz.Shout);
		}
		[Test]
		public void DivisibleBy3()
		{
			GameClass numberFizzBuzz = new GameClass();
			numberFizzBuzz.DivisibleBy3 (3);
			Assert.AreEqual("Fizz", numberFizzBuzz.Shout);
		}

		[Test]
		public void DivisibleBy5()
		{
			GameClass numberFizzBuzz = new GameClass();
			numberFizzBuzz.DivisibleBy5 (5);
			Assert.AreEqual("Buzz", numberFizzBuzz.Shout);
		}
	}
}