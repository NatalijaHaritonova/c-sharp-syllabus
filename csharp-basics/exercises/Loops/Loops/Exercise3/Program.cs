namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("Which number position out of 20 random numbers you want to know?");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(numbers[index]);
        }
    }
}
