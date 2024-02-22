namespace Strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Intro();
			string sentence = "My name is İbrahim Hakkı Doğan";
            Console.WriteLine(sentence.Length);
			var result = sentence.Clone(); //Copy value
			sentence = "My name is Engin Demiroğ";

			bool result2 = sentence.EndsWith("n");
			bool result3 = sentence.StartsWith("e");

			var result4 = sentence.IndexOf("name"); //Returns the starting index where the word is found
			Console.WriteLine(result4);

			var result5 = sentence.IndexOf(' '); // The first index of the find is returned.
			var result6 = sentence.LastIndexOf(" "); //Starts searching from the end
			var result7 = sentence.Insert(0,"Hello, ");
			var result8 = sentence.Substring(3,4);
			Console.WriteLine(result8);
			var result9 = sentence.ToLower();
			var result10 = sentence.ToUpper();
			var result11 = sentence.Replace(" ", "-");
			var result12 = sentence.Remove(2,4);
			Console.WriteLine(result12);
		}

		private static void Intro()
		{
			string city = "Ankara";
			Console.WriteLine(city[0]);

			foreach (var item in city)
			{
				Console.WriteLine(item);
			}

			string city2 = "İstanbul";
			Console.WriteLine(String.Format("{0}{1}", city, city2));
		}
	}
}
