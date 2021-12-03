namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int num = number.Next(100);
            int guess = num - number.Next(10);
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            Console.WriteLine(">" + guess);
            int inputNum = int.Parse(Console.ReadLine());
            
            if (inputNum == num) 
            {
                Console.WriteLine("You guessed it!  What are the odds ?!?");
            }
            else if (inputNum > num) 
            {
                Console.WriteLine("Sorry, you are too high.  I was thinking of " + num + ".");
            }
            else if (inputNum < num) 
            {
                Console.WriteLine("Sorry, you are too low.  I was thinking of " + num + ".");
            }
        }
    }
}
