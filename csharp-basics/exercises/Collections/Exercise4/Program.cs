using System.Globalization;

namespace Exercise4
{
    class Program
    {
        private static string numbers;
        private static int sum = 0;
        private static int checkN;
        private static List<int> numInts = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            numbers = Console.ReadLine();
            checkN = Convert.ToInt32(numbers);
            
            FillList(numbers);
            while (checkN > 1)
            {
                CountSum(numInts);
                if (IsSumOne(sum))
                {
                    Console.WriteLine(numbers + " is Happy");
                    checkN = 0;
                }
                else
                {
                    CheckSumForNum(sum);
                    ClearList();
                    FillList(sum.ToString());
                }
            }
        }

        static void CountSum(List<int> nums)
        {
            sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i] * nums[i];
            }
        }

        static void FillList(string str)
        {
            foreach (char i in str)
            {
                numInts.Add(CharUnicodeInfo.GetDecimalDigitValue(i));
            }
        }

        static bool IsSumOne(int sum)
        {
            return sum == 1;
        }
        static void ClearList()
        {
            numInts.RemoveRange(0, numInts.Count);
        }

        static void CheckSumForNum(int sum)
        {
            if (sum == checkN || sum == 4)
            {
                Console.WriteLine(numbers + " is not happy");
                checkN = 0;
            }
        }
    }
}