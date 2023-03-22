namespace Lists;

using Classes;

class DrivesForSale
{
    public List<Drive> Hardware { get; set; } = new List<Drive>
    {
        new Drive
        {
            Price = 1000,
            Supplier = "Company 1",
            Country = "Country 1",
            Name = "Drive 1",
            Size = 240,
            Speed = 100,
            Interface = "PATA"
        },
        new Drive
        {
            Price = 2000,
            Supplier = "Company 2",
            Country = "Country 2",
            Name = "Drive 2",
            Size = 480,
            Speed = 200,
            Interface = "SATA"
        },
        new Drive
        {
            Price = 3000,
            Supplier = "Company 3",
            Country = "Country 3",
            Name = "Drive 3",
            Size = 250,
            Speed = 400,
            Interface = "SATA",
            Lifetime = 70
        }
    };
}
