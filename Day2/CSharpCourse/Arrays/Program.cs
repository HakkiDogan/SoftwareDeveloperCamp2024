namespace Arrays;

internal class Program
{
	static void Main(string[] args)
	{
		string[] students = new string[3];
		string[] students2 = new string[] {"Cemil", "Mehmet"};
		string[] students3 = {"Ahmet", "Cengiz"};
		students[0] = "Engin";
		students[1] = "Derin";
		students[2] = "Salih";

		foreach (string student in students)
		{
            Console.WriteLine(student);
        }

		string[,] regions = new string[5, 3]
		{
			{"İstanbul" ,"İzmit","Balıkesir"},
			{"Ankara" ,"Konya","Kırıkkale"},
			{"Antalya" ,"Adana","Mersin"},
			{"Rize" ,"Trabzon","Samsun"},
			{"İzmir" ,"Muğla","Manisa"}
		};
		//GetUpperBound(0) son indexin sayısını verir.
		for (int i = 0; i <= regions.GetUpperBound(0); i++) //Satırları uzunluğu kadar
		{
			for (int j = 0; j <= regions.GetUpperBound(1); j++) //1.Dimension yani sütunları almış oluyoruz
			{
				Console.WriteLine(regions[i,j]);
            }
		}
	}
}

