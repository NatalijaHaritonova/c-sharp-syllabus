namespace Exercise8
{
    class AsciiFigure
    {
        static int rows = 5;
        static void Main(string[] args)
        {
            string right = "//";
            string left = @"\\";
            string stars = "**";
            int coef = rows / 2 - 1;
            int slashQ = rows + coef * 2 + 1;
            int charQ = slashQ * 2;
            int countSlash = 0;

            for (int t = 0; t < rows; t++)
            {
                for (int i = slashQ; i > 0; i--)
                {
                    Console.Write(right);
                    countSlash++;
                }
                int starQ = charQ - countSlash * 2;
                for (int i = 0; i < starQ; i++)
                {
                    Console.Write(stars);
                }
                for (int i = slashQ; i > 0; i--)
                {
                    Console.Write(left);
                }
                Console.WriteLine();
                slashQ -= 2;
                countSlash = 0;
            }
        }
    }
}
