namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(new CheckOddEven().OddOrEven(num));
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
