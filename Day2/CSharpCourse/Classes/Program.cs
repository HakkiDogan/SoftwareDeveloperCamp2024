namespace Classes;

internal class Program
{
	static void Main(string[] args)
	{
		//Pascal case    Camel case
		CustomerManager customerManager = new();
		customerManager.Add();
		customerManager.Update();

		ProductManager productManager = new();
		productManager.Add();
		productManager.Update();

		Customer customer = new();
		customer.City = "İzmir";
		customer.Id = 1;
		customer.FirstName = "Hakkı";
		customer.LastName = "Doğan";

		Customer customer2 = new Customer()
		{
			Id = 2,
			City = "Adana",
			FirstName = "Engin",
			LastName = "Demiroğ"
		};

        Console.WriteLine(customer2.FirstName);
    }
}
