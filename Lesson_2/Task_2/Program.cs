/*
* Lesson 2 Task 2: get a collection of users, then ask minimum and maximum search age and output the matching users
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

List<Person> people = new List<Person>()
{
    new Person("Tom",18),
    new Person("Bob",26),
    new Person("Sam",40),
    new Person("Vadim",57),
    new Person("Alex",80)
};

string? userInput;

int minimum;
int maximum;

do
{
	Console.Write("Enter minimum age: ");
	userInput = Console.ReadLine();
} while (!int.TryParse(userInput, out minimum) || minimum < 0 || minimum > 130);

do
{
	Console.Write("Enter maximum age: ");
	userInput = Console.ReadLine();
} while (!int.TryParse(userInput, out maximum) || maximum < minimum || maximum > 130);

var selected = from s in people where s.Age >= minimum && s.Age <= maximum select s;

foreach (Person person in selected)
{
	Console.WriteLine(person);
}

class Person
{
	public string Name { get;}
	public int Age { get;}

	public override string ToString()
	{
		return "Name: " + Name + ", Age: " + Age;
	}

	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}
}
