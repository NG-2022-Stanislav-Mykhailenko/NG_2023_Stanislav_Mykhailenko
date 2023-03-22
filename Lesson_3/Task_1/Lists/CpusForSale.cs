namespace Lists;

using Classes;

class CpusForSale
{
    public List<Cpu> Hardware { get; set; } = new List<Cpu>
    {
        new Cpu
        {
            Price = 1000,
            Supplier = "Company 1",
            Country = "Country 1",
            Name = "CPU 1",
            Socket = "Socket 1",
            Cores = 1,
            Frequency = 2000
        },
        new Cpu
        {
            Price = 2000,
            Supplier = "Company 2",
            Country = "Country 2",
            Name = "CPU 2",
            Socket = "Socket 1",
            Cores = 2,
            Frequency = 3000
        },
        new Cpu
        {
            Price = 3000,
            Supplier = "Company 3",
            Country = "Country 3",
            Name = "CPU 3",
            Socket = "Socket 2",
            Cores = 4,
            Frequency = 2000
        }
    };
}
