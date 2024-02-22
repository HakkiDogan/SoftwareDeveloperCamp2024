namespace Interfaces;

internal class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
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
}
