/*
* Lesson 2 Task 1: get a collection of ten products and their prices, then output them sorted by their price, both ascending and descending
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

using ProductClass;

List<Product> products = new List<Product>();

for (int i = 0; i < 10; i++)
{
    string name;
    float price;

    while (true)
    {
        Console.Write($"Enter product {i + 1} name: ");
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            name = input;
            break;
        }
    }


    while (true)
    {
        Console.Write($"Enter product {i + 1} price: ");
        if (float.TryParse(Console.ReadLine(), out price))
            break;
    }

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
