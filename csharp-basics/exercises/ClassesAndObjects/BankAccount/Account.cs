using System;

namespace BankAccount
{
    internal class Account
    {
        private string _name;
        private double _balance;

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            Math.Round(_balance, 2);
            string s = _balance.ToString("C", new System.Globalization.CultureInfo("en-US"));
            if (_balance < 0)
            {
                return $"{_name}, -{s}";
            }
            else
            {
                return $"{_name}, {s}";
            }
        }
    }
}
