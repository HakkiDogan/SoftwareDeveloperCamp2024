namespace InterfacesDemo;

internal class Program
{
	static void Main(string[] args)
	{
		IWorker[] workers = new IWorker[3]
		{
			new Manager(),
			new Worker(),
			new Robot()
		};

		foreach (var worker in workers)
		{
			worker.Work();
		}

		IHuman[] humans = new IHuman[2]
		{
			new Manager(),
			new Worker(),
		};

		foreach (var human in humans)
		{
			human.Eat();
			human.GetSalary();
		}
	}
	//SOLID Interface Segregation
	interface IWorker
	{
		void Work();		
	}

	interface IHuman
	{
		void Eat();
		void GetSalary();
	}

	class Manager : IWorker, IHuman
	{
		public void Eat()
		{
            Console.WriteLine("Eated");
        }

		public void GetSalary()
		{
			Console.WriteLine("10000");
		}

		public void Work()
		{
			Console.WriteLine("Worked");
		}
	}

	class Worker : IWorker, IHuman
	{
		public void Eat()
		{
			Console.WriteLine("Eated");
		}

		public void GetSalary()
		{
			Console.WriteLine("5000");
		}

		public void Work()
		{
			Console.WriteLine("Worked");
		}
	}

	class Robot : IWorker
	{
		public void Work()
		{
			Console.WriteLine("Worked");
		}
	}
}
