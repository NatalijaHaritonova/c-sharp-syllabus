namespace Firm
{
    public class Commission : Hourly
    {
        public double _totalSales { get; set; } = 0;
        private double _commissRate = 0;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber,
            double rate, double commissRate) : base (eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissRate = commissRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales * _commissRate;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            return result;
        }

        public override double Pay
        {
            get
            {
                return base.Pay + _totalSales;
            }
        }
    }
}
