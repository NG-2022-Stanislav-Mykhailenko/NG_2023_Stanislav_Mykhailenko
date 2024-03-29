/*
* Lesson 2 Task 3: get a collection of customer, then ask for a name and output the matching users, and also count how many of the selected users are older than 18
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

using CustomerClass;

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

string name;

while (true)
{
    Console.Write("Enter name: ");
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        name = input;
        break;
    }
}

var selected = from customer in customers where customer.Name == name select customer;

foreach (Customer customer in selected)
{
    Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, Address: {customer.Address}");
}

var number = selected.Where(customer => customer.Age >= 18).Count();

Console.WriteLine("Amount of customers older than 18: " + number);
