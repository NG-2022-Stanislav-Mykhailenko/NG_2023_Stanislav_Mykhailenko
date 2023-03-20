namespace OwnerClass;

class Owner
{
    public int Id { get;}
    public string Name { get;}
    public string Address { get;}

    public Owner(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}
