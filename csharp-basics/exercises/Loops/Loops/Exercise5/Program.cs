using System;
namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string wOne = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string wTwo = Console.ReadLine();
            int dots = 30 - wOne.Length - wTwo.Length;
            Console.Write(wOne);
            for (int i = 0; i < dots; i++)
            {
                Console.Write(".");
            }
            Console.Write(wTwo);
            Console.ReadKey();
        }
    }
}