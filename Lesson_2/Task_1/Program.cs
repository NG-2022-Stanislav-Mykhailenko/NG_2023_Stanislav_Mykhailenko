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

	do
	{
		Console.Write($"Enter product {i + 1} name: ");
		name = Console.ReadLine();
	} while (name == null);

	do
	{
		Console.Write($"Enter product {i + 1} price: ");
	} while (!float.TryParse(Console.ReadLine(), out price));

	products.Add(new Product(name, price));
}

for (int i = 0; i < 2; i++)
{
	bool descending = Convert.ToBoolean(i);

	products.Sort((first,second) => (descending ? second.Price.CompareTo(first.Price) : first.Price.CompareTo(second.Price)));

	Console.WriteLine($"Sorted {(descending ? "descending" : "ascending")}:");

	foreach (Product product in products)
	{
		Console.WriteLine(product);
	}
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

