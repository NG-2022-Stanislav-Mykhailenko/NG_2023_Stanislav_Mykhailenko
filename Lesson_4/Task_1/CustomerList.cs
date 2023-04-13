namespace SingleResponsibility
{
    public class CustomerList
    {
        public List<Customer> Customers = new List<Customer>()
        {
            new Customer(1, "Fikus", 0),
            new Customer(2, "VHarbar", 100000)
        };

        public Customer? GetById(int id)
        {
            return Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
