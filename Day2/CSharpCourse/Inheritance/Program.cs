namespace Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person[] persons = new Person[3]
			{
				new Person{Id =1,FirstName="Hakkı",LastName="Doğan" },
				new Student{Id=2, FirstName="Engin",LastName="Demiroğ",Department="IT"},
				new Customer{Id= 3, FirstName="Mert",LastName="Dağ",City="Van"},
			};

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }

	}

	interface IPerson
	{

	}

	class Person : IPerson
	{
        public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

    }

	class Customer : Person 
	{
        public string City { get; set; }
    }

	class Student : Person
	{
        public string Department { get; set; }
    }
}
