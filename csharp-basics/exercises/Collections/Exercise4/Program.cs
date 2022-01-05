using System;
using System.Globalization;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            string numbers = Console.ReadLine();
            int checkN = Convert.ToInt32(numbers);
            List<int> numInts = new List<int>();
            int sum = 0;

            FillList(numbers);
            while(checkN > 1)
            {
                CountSum(numInts);
                if (CheckSum(sum))
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

            void CountSum(List<int> nums)
            {
                sum = 0;
                for (int i = 0; i < nums.Count; i++)
                {
                    sum += nums[i] * nums[i];
                }
            }

            void FillList(string str)
            {
                foreach (char i in str)
                {
                    numInts.Add(CharUnicodeInfo.GetDecimalDigitValue(i));
                }
            }

            bool CheckSum(int sum)
            {
                bool check = false;
                if (sum == 1)
                {
                    check = true;
                }
                return check;
            }
            void ClearList()
            {
                numInts.RemoveRange(0, numInts.Count);
            }

            void CheckSumForNum(int sum)
            {
                if (sum == checkN)
                {
                    Console.WriteLine(numbers + " is not happy");
                    checkN = 0;
                }
            }
        }

    }
}