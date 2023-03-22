namespace Lists;

using Classes;

class GpusForSale
{
    public List<Gpu> Hardware { get; set; } = new List<Gpu>
    {
        new Gpu
        {
            Price = 1000,
            Supplier = "Company 1",
            Country = "Country 1",
            Name = "GPU 1",
            Memory = 2048,
            Speed = 2000
        },
        new Gpu
        {
            Price = 2000,
            Supplier = "Company 2",
            Country = "Country 2",
            Name = "GPU 2",
            Memory = 4096,
            Speed = 3000
        },
        new Gpu
        {
            Price = 3000,
            Supplier = "Company 3",
            Country = "Country 3",
            Name = "GPU 3",
            Memory = 8192,
            Speed = 4000
        }
    };
}
