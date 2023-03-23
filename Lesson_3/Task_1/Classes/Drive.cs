namespace Classes;

class Drive : Detail
{
    public required int Size { get; set; }
    public required int Speed { get; set; }
    public required string Interface { get; set; }
    public int? Lifetime { get; set; }
}
