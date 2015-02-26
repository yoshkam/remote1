using System;

namespace RADARstudio
{
	public class ConsoleTest
	{
		static void Main()
		{
			Console.WriteLine("Hello, world!");

			Console.WriteLine("What is your name?");
			var n = Console.ReadLine();

			if (!String.IsNullOrEmpty(n))
			{
				Console.WriteLine("Your name is " + n + "");
			}
		}
	}
}
