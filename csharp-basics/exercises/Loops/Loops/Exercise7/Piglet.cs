namespace Exercise7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Random rnd = new Random();
            int times = 30;
            int score = 0;
            for (int i = 0; i < times; i++)
            {
                int rolledNum = rnd.Next(1, 7);
                if (rolledNum != 1)
                {
                    Console.WriteLine("You rolled a " + rolledNum + "!");
                    score += rolledNum;
                    Console.WriteLine("Roll again? (yes/no)");
                    string yesNo = Console.ReadLine();
                    if (yesNo == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You got " + score + " points.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You rolled a " + rolledNum + "!");
                    Console.WriteLine("You got 0 points.");
                    break;
                }
            }
        }
    }
}
