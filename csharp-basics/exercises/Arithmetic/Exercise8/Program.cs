namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter pay: ");
            double pay = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter hours worked: ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total pay is {new Salary().TotalPay(pay, hours)}$.");
            Console.ReadLine();
        }
    }
}
