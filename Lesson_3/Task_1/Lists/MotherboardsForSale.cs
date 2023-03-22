namespace Lists;

using Classes;

class MotherboardsForSale
{
    public List<Motherboard> Hardware { get; set; } = new List<Motherboard>
    {
        new Motherboard
        {
            Price = 1000,
            Supplier = "Company 1",
            Country = "Country 1",
            Name = "Motherboard 1",
            RamType = "DDR2",
            RamSlots = 2,
            Socket = "Socket 1",
            CpuSlots = 1,
            PataSlots = 2,
            SataSlots = 2
        },
        new Motherboard
        {
            Price = 2000,
            Supplier = "Company 2",
            Country = "Country 2",
            Name = "Motherboard 2",
            RamType = "DDR3",
            RamSlots = 4,
            Socket = "Socket 1",
            CpuSlots = 1,
            PataSlots = 1,
            SataSlots = 4
        },
        new Motherboard
        {
            Price = 3000,
            Supplier = "Company 3",
            Country = "Country 3",
            Name = "Motherboard 3",
            RamType = "DDR4",
            RamSlots = 4,
            Socket = "Socket 2",
            CpuSlots = 1,
            PataSlots = 0,
            SataSlots = 4
        }
};
}
