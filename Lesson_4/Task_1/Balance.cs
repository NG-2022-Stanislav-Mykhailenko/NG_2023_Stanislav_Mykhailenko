namespace SingleResponsibility
{
    public class Balance
    {
        private readonly CustomerList _customerList;

        public Balance(CustomerList customerList)
        {
            _customerList = customerList;
        }

        public void GetBalance(int id)
        {
            Console.WriteLine($"Your balance is: {GetBalanceById(id)}");
        }

        public decimal? GetBalanceById(int id)
        {
            var customer = _customerList.GetById(id);
            if (customer != null)
                return customer.Balance;
            return null;
        }

        public void UpdateBalance(int id, decimal newBalance)
        {
            var customer = _customerList.GetById(id);
            if (customer != null)
                customer.Balance = newBalance;
        }
    }
}
