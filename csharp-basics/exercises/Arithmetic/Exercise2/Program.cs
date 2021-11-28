// Write a program called CheckOddEven which prints "Odd Number" if the int variable “number” is odd,
// or “Even Number” otherwise. The program shall always print “bye!” before exiting.
namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckOddEven(24);
            static void CheckOddEven(int num1) 
            {
            if (num1 % 2 == 0) 
                {
                    Console.WriteLine("Even Number");
                }
            else if (num1 % 2 != 0) 
                {
                    Console.WriteLine("Odd Number");
                }
            }
            Console.ReadKey();
            Console.WriteLine("bye!");
        }
    }
}
