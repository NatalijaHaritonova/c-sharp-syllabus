//Write a program that asks the user to enter a series of single digit numbers and calculate the sum of all the numbers.
namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter few single digit numbers separated by commas");
            string inputData;
            inputData = Console.ReadLine();
            string[] stringList = inputData.Split(',');
            int[] intList = Array.ConvertAll(stringList, s => int.Parse(s));
            int i;
            int listSum = 0;
            for (i = 0; i < intList.Length; i++)
            {
                listSum += intList[i];
            }
            Console.WriteLine(listSum);
        }
    }
}
