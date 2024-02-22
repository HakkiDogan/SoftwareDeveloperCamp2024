namespace Methods;

internal class Program
{
	static void Main(string[] args)
	{
		//Add();
		//var result = Add2(5,10);
		//Console.WriteLine(result);
		// Ref ile out farkı 		
		int number1 = 20;
		int number2 = 100;
		// Ref kullanıldığında değiken önceden set edilmek zorunda 
		var result2 = Add3(ref number1, number2);
		// Out kullanıldığında tanımlanması yeterlidir.
		int number3;
		var result3 = Add2(out number3, number2);

		Console.WriteLine(result2);
		Console.WriteLine(result3);

		Console.WriteLine(Multiply(2, 3));
		Console.WriteLine(Multiply(2, 3, 4));

        Console.WriteLine(Add4(2,3,4,5,6,7,8));
    }

	static void Add()
	{
		Console.WriteLine("Added!");
	}

	static int Add2(out int number2, int number3 = 30) //Default value
	{
		number2 = 30;
		var result = number2 + number3;
		return result;
	}

	static int Add3(ref int number1, int number2)
	{
		number1 = 30;
		return number1 + number2;
	}

	static int Add4(params int[] numbers)
	{
		return numbers.Sum();
	}

	static int Multiply(int number1, int number2)
	{
		var result = number1 * number2;
		return result;
	}

	static int Multiply(int number1, int number2, int number3)
	{
		var result = number1 * number2 + number3;
		return result;
	}
}
