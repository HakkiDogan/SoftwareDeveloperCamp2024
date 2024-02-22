namespace Interfaces;

internal class Program
{
	static void Main(string[] args)
	{
		//InterfacesIntro();
		//Demo();
		ICustomerDal[] customerDals = new ICustomerDal[2]
		{
			new SqlServerCustomerDal(),
			new OracleCustomerDal()
		};
		foreach (var customerDal in customerDals)
		{
			customerDal.Add();
		}
	}

	private static void Demo()
	{
		CustomerManager customerManager = new CustomerManager();
		customerManager.Add(new SqlServerCustomerDal());
		customerManager.Add(new OracleCustomerDal());
	}

	private static void InterfacesIntro()
	{
		PersonManager manager = new();
		Customer customer = new Customer
		{
			Firstname = "Test",
			Address = "İzmir",
			Id = 1,
			LastName = "Test",
		};
		manager.Add(customer);

		Student student = new Student
		{
			LastName = "Test",
			Id = 1,
			Firstname = "Test",
			Department = "IT"
		};
		manager.Add(student);
	}

	interface IPerson
	{
        int Id { get; set; }
        string Firstname { get; set; }
		string LastName { get; set; }
    }

	class Customer : IPerson
	{
		public int Id { get; set; }
		public string Firstname { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
	}

	class Student : IPerson
	{
		public int Id { get; set; }
		public string Firstname { get; set; }
		public string LastName { get; set; }
        public string Department { get; set; }
    }

	class PersonManager
	{
		public void Add(IPerson customer)
		{
            Console.WriteLine(customer.Firstname);
        }
	}
}
