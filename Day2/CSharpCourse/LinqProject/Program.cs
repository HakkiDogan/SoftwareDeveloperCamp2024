using System.Security.Cryptography.X509Certificates;

namespace LinqProject;

internal class Program
{
	static void Main(string[] args)
	{
		List<Category> categories = new List<Category>
		{
			new Category{CategoryId = 1, CategoryName="Bilgisayar"},
			new Category{CategoryId = 2, CategoryName="Telefon"}
		};

		List<Product> products = new List<Product>
		{
			new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5},
			new Product{ProductId=2,CategoryId=1,ProductName="Msi Laptop",QuantityPerUnit="64 GB Ram",UnitPrice=25000,UnitsInStock=3},
			new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=8000,UnitsInStock=2},
			new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=30000,UnitsInStock=20},
			new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="2 GB Ram",UnitPrice=40000,UnitsInStock=0},
		};

		GetProducts(products);
		GetProductsLinq(products);

    }

	static List<Product> GetProducts(List<Product> products)
	{
		List<Product> result = new List<Product>();

		foreach (var product in products)
		{
			if (product.UnitPrice > 12000 && product.UnitsInStock > 3)
				result.Add(product);
		};

		return result;
	}

	static List<Product> GetProductsLinq(List<Product> products)
	{
		var result = products.Where(p => p.UnitPrice > 12000 && p.UnitsInStock > 0).ToList();

		return result;
	}
}


class Product
{
	public int ProductId { get; set; }
	public int CategoryId { get; set; }
	public string ProductName { get; set; }
	public string QuantityPerUnit { get; set; }
	public decimal UnitPrice { get; set; }
	public int UnitsInStock { get; set; }
}

class Category
{
	public int CategoryId { get; set; }
	public string CategoryName { get; set; }
}
