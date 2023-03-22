namespace Classes;

class Motherboard : Detail
{
    public string RamType { get; set; }
    public int RamSlots { get; set; }
    public int UsedRamSlots {get; set; }
    public string Socket { get; set; }
    public int CpuSlots {get; set; }
    public int UsedCpuSlots {get; set; }
    public int PataSlots { get; set; }
    public int UsedPataSlots {get; set; }
    public int SataSlots { get; set; }
    public int UsedSataSlots {get; set; }
}
