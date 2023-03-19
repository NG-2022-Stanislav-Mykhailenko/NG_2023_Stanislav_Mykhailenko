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

int minimum;
int maximum;

while (true)
{
    Console.Write($"Enter minimum age: ");
    if (int.TryParse(Console.ReadLine(), out minimum) || minimum >= 0 || minimum <= 130)
        break;
}

while (true)
{
    Console.Write($"Enter maximum age: ");
    if (int.TryParse(Console.ReadLine(), out maximum) || maximum >= minimum || maximum <= 130)
        break;
}

var selected = from person in people where person.Age >= minimum && person.Age <= maximum select person;

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
