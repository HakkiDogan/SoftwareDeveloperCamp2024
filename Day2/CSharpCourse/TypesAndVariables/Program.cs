namespace TypesAndVariables;

internal class Program
{
	static void Main(string[] args)
	{
		//Value Types
		char character = 'a';
		bool condition = false;
		byte number4 = 255; //8 Bit
		short number3 = 3; //16 Bit
		int number1 = 2147483647; //32 Bit
		long number2 = 2147483648; //64 Bit
		double number5 = 10.5; //64 Bit
		decimal number6 = 10.78m;
		var number7 = 10;
		number7 = character;
		Console.WriteLine("Number1 is {0}",number1);
		Console.WriteLine("Number1 is {0}",number2);
		Console.WriteLine("Number1 is {0}",number3);
		Console.WriteLine("Number1 is {0}",number4);
		Console.WriteLine("Number1 is {0}",number5);
		Console.WriteLine("Number1 is {0}",number6);
		Console.WriteLine("Number1 is {0}",number7);
		Console.WriteLine("Character is {0}",(int)character);
		Console.WriteLine((int)Days.Friday);
        //Console.WriteLine("Hello, World!");
    }
}

enum Days
{
	Monday = 1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
}