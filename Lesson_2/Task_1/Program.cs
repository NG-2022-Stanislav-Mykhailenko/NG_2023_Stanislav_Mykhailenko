/*
* Lesson 2 Task 1: get a collection of ten products and their prices, then output them sorted by their price, both ascending and descending
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

List<Product> products = new List<Product>();

for (int i = 0; i < 10; i++)
{
	string? name;
	float price;
	string? userInput;

	do
	{
		Console.Write(string.Format("Enter product {0} name: ", i + 1));
		name = Console.ReadLine();
	} while (name == null);

	do
	{
		Console.Write(string.Format("Enter product {0} price: ", i + 1));
		userInput = Console.ReadLine();
	} while (!float.TryParse(userInput, out price));

	products.Add(new Product(name, price));
}

products.Sort((x,y) => x.Price.CompareTo(y.Price));

Console.WriteLine("Sorted ascending: ");

foreach (Product product in products)
{
	Console.WriteLine(product);
}

products.Sort((x,y) => y.Price.CompareTo(x.Price));

Console.WriteLine("Sorted descending: ");

foreach (Product product in products)
{
	Console.WriteLine(product);
}

class Product
{
	public string Name { get;}
	public float Price { get;}

	public override string ToString()
	{
		return "Name: " + Name + ", Price: " + Price;
	}

	public Product(string name, float price)
	{
		Name = name;
		Price = price;
	}
}
