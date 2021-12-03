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
                        if (lines[i, t] % 3 == 0 && lines[i, t] % 5 == 0)
                        {
                            Console.Write("CozaLoza ");
                        }
                        else if (lines[i, t] % 3 == 0 && lines[i, t] % 7 == 0) 
                        {
                            Console.Write("CozaWoza ");
                        }
                        else if (lines[i, t] % 5 == 0 && lines[i, t] % 7 == 0) 
                        {
                            Console.Write("LozaWoza ");
                        }
                        else if (lines[i, t] % 5 == 0)
                        {
                            Console.Write("Loza ");
                        }
                        else if (lines[i, t] % 7 == 0)
                        {
                            Console.Write("Woza ");
                        }
                        else if (lines[i, t] % 3 == 0) 
                        {
                            Console.Write("Coza ");
                        }
                        else
                        {
                            Console.Write(lines[i, t] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}