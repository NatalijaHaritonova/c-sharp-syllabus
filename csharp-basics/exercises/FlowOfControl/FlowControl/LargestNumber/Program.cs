using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            int input3 = int.Parse(Console.ReadLine());

            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine(input1 + " is largest of entered numbers");
            }
            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine(input2 + " is largest of entered numbers");
            }
            else if (input3 > input1 && input3 > input2)
            {
                Console.WriteLine(input3 + " is largest of entered numbers");
            }
            Console.ReadKey();
        }
    }
}
