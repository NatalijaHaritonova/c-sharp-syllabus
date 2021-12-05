using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();
            Int64 result;

            if (Int64.TryParse(input, out result)) 
            {
                if (result < 0) 
                {
                    result *= -1;
                }

                if (result >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int numOfDigits = result.ToString().Length;
                    int digits = 1;
                    for (int i = 0; i < numOfDigits; i++)
                    {
                        if (numOfDigits > digits)
                            digits++;
                    }
                    Console.WriteLine("Number of digits in the number: " + digits);
                    Console.ReadKey();
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadKey();
        }
    }
}
