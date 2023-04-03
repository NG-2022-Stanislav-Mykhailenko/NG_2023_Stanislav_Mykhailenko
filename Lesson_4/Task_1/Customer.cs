﻿namespace SingleResponsibility
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        
        public Customer(int id, string name, decimal balance)
        {
            Id = id; 
            Name = name; 
            Balance = balance;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Your balance is: {Balance}");
        }
    }

    public class CustomerList
    {
        public List<Customer> Customers = new List<Customer>()
        {
            new Customer(1, "Fikus", 0),
            new Customer(2, "VHarbar", 100000)
        };

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

        public void SaveToDatabase()
        {
            Console.WriteLine("Saved!");
        }

        public void UpdateBalance(int id, decimal newBalance)
        {
            var customer = GetById(id);
            if (customer != null)
            {
                customer.Balance = newBalance;
                SaveToDatabase();
            }
        }
    }
}
