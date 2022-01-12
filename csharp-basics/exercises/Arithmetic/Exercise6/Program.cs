namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            CozaLozaWoza();
            static void CozaLozaWoza() 
            {
                int i, t;
                int[,] lines = new int[22, 11];
                for (i = 0; i < 10; i++) 
                {
                    for (t = 0; t < 11; t++) 
                    {
                        lines[i, t] = (i * 11) + t + 1;
                        Console.Write(new CozaLozaWoza().CozaLozaWozaNumCheck(lines[i, t]));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}