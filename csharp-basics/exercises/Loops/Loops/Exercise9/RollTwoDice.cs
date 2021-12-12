namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desired sum:");
            int sumD = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int realSum = dice1 + dice2;
                if (sumD == realSum)
                {
                    Console.WriteLine(dice1 + " and " + dice2 + " = " + realSum);
                    break;
                }
                else
                {
                    Console.WriteLine(dice1 + " and " + dice2 + " = " + realSum);
                }
            }
        }
    }
}
