namespace Lists;

using Classes;

class RamsForSale
{
    public List<Ram> Hardware { get; set; } = new List<Ram>
    {
        new Ram
        {
            Price = 1000,
            Supplier = "Company 1",
            Country = "Country 1",
            Name = "RAM 1",
            Type = "DDR2",
            Size = 2048
        },
        new Ram
        {
            Price = 2000,
            Supplier = "Company 2",
            Country = "Country 2",
            Name = "RAM 2",
            Type = "DDR3",
            Size = 4096
        },
        new Ram
        {
            Price = 4000,
            Supplier = "Company 3",
            Country = "Country 3",
            Name = "RAM 3",
            Type = "DDR4",
            Size = 8192
        }
    };
}
