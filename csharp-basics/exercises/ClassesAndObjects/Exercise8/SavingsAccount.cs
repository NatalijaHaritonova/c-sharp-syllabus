namespace Exercise8
{
    internal class SavingsAccount
    {
        private double _annualIntRate;
        public double _balance { get; set; }

        public SavingsAccount(double startBalance)
        {
            _balance = startBalance;
        }

        public double Withdraw(double amount)
        {
            return _balance -= amount;
        }

        public double Deposit(double amount)
        {
            return _balance += amount;
        }

        public double MonthlyInterest()
        {
            return _balance += _annualIntRate / 12 * _balance;
        }

        public void AnnualIntRate(double rate)
        {
            _annualIntRate = rate;
        }
    }
}
