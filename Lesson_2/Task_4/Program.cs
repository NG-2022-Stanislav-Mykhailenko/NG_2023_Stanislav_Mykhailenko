/*
* Lesson 2 Task 4: get two collections with cars and their owners and ask car number, then return its owner's name and address
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

using CarClass;
using OwnerClass;

List<Owner> owners = new List<Owner>()
{
    new Owner(1, "Tom", "Street 1"),
    new Owner(2, "Bob", "Street 2"),
    new Owner(3, "Sam", "Street 3"),
};

List<Car> cars = new List<Car>()
{
    new Car("123ABC", 1),
    new Car("456DEF", 2),
    new Car("789GHI", 3),
};

string? number;

while (true)
{
    Console.Write("Enter number: ");
    number = Console.ReadLine();
    if (number != null)
        break;
}

var selected = owners.FirstOrDefault(owner => cars.Any(car => car.Number == number && car.OwnerId == owner.Id));

Console.WriteLine(selected);
