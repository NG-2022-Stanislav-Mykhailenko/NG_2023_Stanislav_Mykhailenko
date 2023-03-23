namespace Classes;

class Cpu : Detail
{
    public required string Socket { get; set; }
    public required int Cores { get; set; }
    public required int Frequency { get; set; }
}
