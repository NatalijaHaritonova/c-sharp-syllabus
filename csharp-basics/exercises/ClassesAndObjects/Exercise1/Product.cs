namespace Exercise1
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _amount;
        private double _priceUpd;
        private int _amountUpd;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public string PrintProduct()
        {
            return _name + ", price " + _price + ", amount " + _amount;
        }

        public void ChangePrice()
        {
            _priceUpd = 5;
            _price = _price + _priceUpd;
        }

        public void ChangeAmount()
        {
            _amountUpd = 2;
            _amount = _amount + _amountUpd;
        }
    }
}
