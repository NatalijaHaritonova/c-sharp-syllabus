namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product first = new Product("Logitech mouse", 70.00, 14);
            Product second = new Product("iPhone 5s", 999.99, 3);
            Product third = new Product("Epson EB-U05", 440.46, 1);
            first.PrintProduct();
            second.PrintProduct();
            third.PrintProduct();
            Console.WriteLine();
            first.ChangePrice();
            first.PrintProduct();
            second.ChangeAmount();
            second.PrintProduct();
        }
    }

    class Product
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

        public void PrintProduct()
        {
            Console.WriteLine(_name + ", price " + _price + ", amount " + _amount);
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