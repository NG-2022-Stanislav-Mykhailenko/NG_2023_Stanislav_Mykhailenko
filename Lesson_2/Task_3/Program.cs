/*
* Lesson 2 Task 3: get a collection of customer, then ask for a name and output the matching users, and also count how many of the selected users are older than 18
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

List<Customer> customers = new List<Customer>()
{
    new Customer("Tom", 14, "Street 1"),
    new Customer("Bob", 26, "Street 2"),
    new Customer("Sam", 10, "Street 3"),
    new Customer("Vadim", 57, "Street 4"),
    new Customer("Alex", 80, "Street 5"),
    new Customer("Alex", 15, "Street 6"),
    new Customer("Tom", 65, "Street 7"),
    new Customer("Andrew", 33, "Street 8"),
    new Customer("Bob", 22, "Street 9"),
    new Customer("Alex", 77, "Street 10")
};

string? name;

do
{
	Console.Write("Enter name: ");
	name = Console.ReadLine();
} while (name == null);

var selected = from customer in customers where customer.Name == name select customer;

foreach (Customer customer in selected)
{
	Console.WriteLine(customer);
}

var number = selected.Where(customer => customer.Age >= 18).Count();

Console.WriteLine("Amount of customers older than 18: " + number);

class Customer
{
	public string Name { get;}
	public int Age { get;}
	public string Address { get;}

	public override string ToString()
	{
		return "Name: " + Name + ", Age: " + Age + ", Address: " + Address;
	}

	public Customer(string name, int age, string address)
	{
		Name = name;
		Age = age;
		Address = address;
	}
}
