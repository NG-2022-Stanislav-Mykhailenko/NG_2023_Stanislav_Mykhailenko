namespace PersonClass;

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
