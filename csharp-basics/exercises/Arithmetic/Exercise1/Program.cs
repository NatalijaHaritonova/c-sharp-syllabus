namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1 number: ");
            var userNum1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2 number: ");
            var userNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine(new Is15Check().Is15(userNum1, userNum2));
        }
    }
}