namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min? ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max? ");
            int max = int.Parse(Console.ReadLine());
            string result = String.Empty;
            int count = 0;
            for (int i = 0; i < max; i++)
            {
                for (int t = min; t <= max; t++)
                {
                    result += t.ToString();
                    count++;
                }
                for (int m = min - 1 * i; m <= max - count; m++)
                {
                    result += m.ToString();
                }
                Console.WriteLine(result);
                result = String.Empty;
                min++;
                count = 0;
            }
        }
    }
}

