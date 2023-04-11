namespace SingleResponsibility
{
    public class CustomerList
    {
        public List<Customer> Customers = new List<Customer>()
        {
            new Customer(1, "Fikus", 0),
            new Customer(2, "VHarbar", 100000)
        };

        public void GetBalance(int id)
        {
            Console.WriteLine($"Your balance is: {GetBalanceById(id)}");
        }

        public decimal? GetBalanceById(int id)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
                return customer.Balance;
            else
                return null;
        }

        public Customer? GetById(int id)
        {
            return Customers.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateBalance(int id, decimal newBalance)
        {
            var customer = GetById(id);
            if (customer != null)
            {
                customer.Balance = newBalance;
                (new Database()).SaveToDatabase();
            }
        }
    }
}
