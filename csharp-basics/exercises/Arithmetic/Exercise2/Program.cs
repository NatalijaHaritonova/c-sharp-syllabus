namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckOddEven(24);
            static void CheckOddEven(int num1) 
            {
                if (num1 % 2 == 0) 
                {
                    Console.WriteLine("Even Number");
                }
                else if (num1 % 2 != 0) 
                {
                    Console.WriteLine("Odd Number");
                }
            }
            Console.ReadKey();
            Console.WriteLine("bye!");
        }
    }
}
