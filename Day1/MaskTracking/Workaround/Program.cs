using Business.Concrete;
using Entities.Concrete;

namespace Workaround;

internal class Program
{
	static void Main(string[] args)
	{
		//Variables();

		SayHello("Engin");
		SayHello("Hakkı");
		SayHello("Tarık");
		SayHello();

		int result = Sum(5, 8);

		//Arrays
		string student1 = "Engin";
		string student2 = "Hakkı";
		string student3 = "Melih";

		string[] ogrenciler = new[] { student1, student2, student3 };

		foreach (var ogrenci in ogrenciler)
		{
			Console.WriteLine(ogrenci);
		}

		string[] cities = new[] { "Ankara", "İstanbul", "İzmir" };
		string[] cities2 = new[] { "Bursa", "Kars", "Konya" };

		cities2 = cities;
		cities[0] = "Adana";


		for (int i = 0; i < cities2.Length; i++)
		{
			Console.WriteLine(cities2[i]);
		}
		
		List<string> cities3 = new List<string>{"Antalya", "Aydın", "Hatay"};
		cities3.Add("Ordu");
        Console.WriteLine("Cities3 Capacity: " + cities3.Capacity);

        foreach (var city in cities3)
        {
            Console.WriteLine(city);
        }

		//Kendi listem
		MyList<string> myList = new MyList<string>();
		myList.Add("item1");
		Console.WriteLine(myList[0]);

		Person person = new();
		person.FirstName = "Hakkı";
		person.LastName = "Doğan";
		person.BirthYear = 1999;
		person.NationalIdentity = 12345678910;

		PttManager pttManager = new PttManager(new PersonManager());
		pttManager.GiveMask(person);


	}

	static void SayHello(string name = "noname")
	{
		Console.WriteLine("Merhaba " + name);
	}

	static int Sum(int num1, int num2)
	{
		int result = num1 + num2;
        Console.WriteLine("Sum: " + result);
		return result;
	}

	private static void Variables()
	{
		string message = "Hello";
		double price = 500.5;
		int number = 85;
		bool isAuthenticated = false;

		string name = "İbrahim";
		string surname = "Doğan";
		int brithDate = 2000;
		long IdentificationNumber = 12345678910;

		Console.WriteLine(price * 1.25);

		Console.WriteLine(name + " " + surname);
	}
}