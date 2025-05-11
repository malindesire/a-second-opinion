using System;

namespace ASecondOpinion
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter seconds: ");
			string userInput = Console.ReadLine();

			getTime(userInput);
		}

		private static int getSeconds(string secondsString)
		{
			int seconds = Int32.Parse(secondsString);
			return seconds;
		}

		private static void getTime(string secondsString)
		{
			int secondsSum = getSeconds(secondsString);

			int hours = (secondsSum - secondsSum % 3600) / 3600;
			int minutes = (secondsSum % 3600 - secondsSum % 3600 % 60) / 60;
			int seconds = secondsSum % 3600 % 60;

			Console.WriteLine(hours + " : " + minutes + " : " + seconds);
		}
	}
}