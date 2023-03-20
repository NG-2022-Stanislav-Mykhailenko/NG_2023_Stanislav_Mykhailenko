namespace ProductClass;

class Product
{
    public string Name { get;}
    public float Price { get;}

    public override string ToString()
    {
        return "Name: " + Name + ", Price: " + Price;
    }

    public Product(string name, float price)
    {
        Name = name;
        Price = price;
    }
}
