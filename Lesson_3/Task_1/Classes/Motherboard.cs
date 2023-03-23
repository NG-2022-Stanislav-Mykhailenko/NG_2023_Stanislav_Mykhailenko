namespace Classes;

class Motherboard : Detail
{
    public required string RamType { get; set; }
    public required int RamSlots { get; set; }
    public int UsedRamSlots { get; set; }
    public required string Socket { get; set; }
    public required int CpuSlots { get; set; }
    public int UsedCpuSlots { get; set; }
    public required int PataSlots { get; set; }
    public int UsedPataSlots {get; set; }
    public required int SataSlots { get; set; }
    public int UsedSataSlots { get; set; }
}
