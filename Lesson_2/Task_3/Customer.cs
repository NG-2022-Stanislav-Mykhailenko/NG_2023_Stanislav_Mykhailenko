namespace CustomerClass;

class Customer
{
    public string Name { get;}
    public int Age { get;}
    public string Address { get;}

    public Customer(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}