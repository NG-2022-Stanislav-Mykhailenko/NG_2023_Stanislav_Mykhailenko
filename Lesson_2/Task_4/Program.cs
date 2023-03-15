/*
* Lesson 2 Task 4: get two collections with cars and their owners and ask car number, then return its owner's name and address
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

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

do
{
	Console.Write("Enter number: ");
	number = Console.ReadLine();
} while (number == null);

var selected = owners.FirstOrDefault(x => cars.Any(y => y.Number == number && y.OwnerID == x.ID));

Console.WriteLine(selected);

class Owner
{
	public int ID { get;}
	public string Name { get;}
	public string Address { get;}

	public override string ToString()
	{
		return "Name: " + Name + ", Address: " + Address;
	}

	public Owner(int id, string name, string address)
	{
		ID = id;
		Name = name;
		Address = address;
	}
}

class Car
{
	public string Number { get;}
	public int OwnerID { get;}

	public override string ToString()
	{
		return "Number: " + Number + ", Owner ID: " + OwnerID;
	}

	public Car(string number, int ownerid)
	{
		Number = number;
		OwnerID = ownerid;
	}
}
