using System;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            int toFind = 2000;

            if (Array.Exists(myArray, x => x == toFind))
            {
                Console.WriteLine("Contains!");
            }
            else
            {
                Console.WriteLine("Do not contain.");
            }

            Console.ReadKey();
        }
    }
}
