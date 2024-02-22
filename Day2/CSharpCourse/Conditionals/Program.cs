﻿namespace Conditionals;

internal class Program
{
	static void Main(string[] args)
	{
		var number = 10;
		if (number == 10)
		{
			Console.WriteLine("Number is 10");
		}
		else if (number == 20)
		{
			Console.WriteLine("Number is 20");
		}
		else
		{
			Console.WriteLine("Number is not 10 or 20");
		}

		//Single Line If
		Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
		Console.WriteLine(number == 10 ? "Number is 10"
									   : number == 20 ? "Number is 20" : "Number is not 10 or 20");

		//SwitchCase
		switch (number)
		{
			case 10:
				Console.WriteLine("Number is 10");
				break;
			case 20:
				Console.WriteLine("Number is 20");
				break;
			default:
				Console.WriteLine("Number is not 10 or 20");
				break;
		}

		if (number >= 0 && number <= 100)
		{
			if (number >= 90 && number <= 95)
			{
				Console.WriteLine("Number is betwwen 90-95");
			}
			else
			{
				Console.WriteLine("Number is betwwen 0-100");
			}
		}
		else if (number > 100 && number <= 200)
		{
			Console.WriteLine("Number is between 101-200");
		}
		else if (number > 200 || number < 0)
		{
			Console.WriteLine("Number is less than 0 or greather than 200");
		}

	}
}
