namespace CarClass;

class Car
{
    public string Number { get;}
    public int OwnerId { get;}

    public Car(string number, int ownerId)
    {
        Number = number;
        OwnerId = ownerId;
    }
}
