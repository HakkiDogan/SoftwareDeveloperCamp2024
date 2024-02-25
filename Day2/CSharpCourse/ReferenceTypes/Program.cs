namespace ReferenceTypes;

internal class Program
{
	static void Main(string[] args)
	{
		////int,decimal,float,enum,boolean value types
		//int sayi1 = 10;
		//int sayi2 = 20;

		//sayi1 = sayi2;

		//sayi2 = 100;
		//Console.WriteLine("Sayı 1 : " + sayi1);

		////arrays,class,interface... referance types
		//int[] numbers = new int[] { 1, 2, 3 };
		//int[] numbers2 = new int[] { 10, 20, 30 };

		//numbers = numbers2;
		//numbers2[0] = 1000;

		//Console.WriteLine("Sayılar1[0] =" + numbers[0]);

		Person person1 = new Person();
		Person person2 = new Person();
		person1.FirstName = "Engin";

		person2 = person1;
		person1.FirstName = "Derin";

        Console.WriteLine(person2.FirstName);

        Customer customer = new Customer();
		customer.FirstName = "Test";
		customer.CreditCardNumber = "123456";
		Person person3 = customer;
		customer.FirstName = "Ahmet";


        Console.WriteLine(((Customer)person3).CreditCardNumber);

        Employee employee = new Employee();
		employee.FirstName = "Mehmet";
		PersonManager personManager = new PersonManager();
		personManager.Add(employee);
		
	}
}

class Person
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

class Customer : Person
{
	public string CreditCardNumber { get; set; }
}

class Employee : Person
{
	public int EmployeeNumber { get; set; }
}

class PersonManager
{
	public void Add(Person person)
	{
        Console.WriteLine(person.FirstName);
    }
}
