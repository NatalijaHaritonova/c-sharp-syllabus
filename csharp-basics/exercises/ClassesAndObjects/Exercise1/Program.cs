namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product first = new Product("Logitech mouse", 70.00, 14);
            Product second = new Product("iPhone 5s", 999.99, 3);
            Product third = new Product("Epson EB-U05", 440.46, 1);
            Console.WriteLine(first.PrintProduct());
            Console.WriteLine(second.PrintProduct());
            Console.WriteLine(third.PrintProduct());
            Console.WriteLine();
            first.ChangePrice();
            Console.WriteLine(first.PrintProduct());
            second.ChangeAmount();
            Console.WriteLine(second.PrintProduct());
        }
    }
}