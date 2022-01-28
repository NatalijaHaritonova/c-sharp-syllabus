namespace Account
{
    class Account
    {
        private string _name;
        private double _balance;

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public void Withdrawal(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public double Balance()
        {
            return _balance;
        }

        public override string ToString()
        {
            return $"{_name}: {_balance}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
