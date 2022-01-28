namespace Exercise9
{
    class RollTwoDice
    {
        private static int realSum;

        static void Main(string[] args)
        {
            Console.WriteLine("Desired sum:");
            int sumD = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            while (sumD != realSum)
                {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                realSum = dice1 + dice2;
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
