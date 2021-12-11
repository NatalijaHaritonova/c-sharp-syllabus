namespace Exercise6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int maxNum = int.Parse(Console.ReadLine());
            int i, t;
            int rows = maxNum / 20 + 1;
            int[,] lines = new int[rows, 20];

            for (i = 0; i < rows; i++)
            {
                for (t = 0; t < 20; t++)
                {
                    lines[i, t] = (i * 20) + t + 1;
                    if (lines[i, t] <= maxNum)
                    {
                        if (lines[i, t] % 3 == 0 && lines[i, t] % 5 == 0)
                        {
                            Console.Write("FizzBuzz ");
                        }
                        else if (lines[i, t] % 3 == 0)
                        {
                            Console.Write("Fizz ");
                        }
                        else if (lines[i, t] % 5 == 0)
                        {
                            Console.Write("Buzz ");
                        }
                        else
                        {
                            Console.Write(lines[i, t] + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
