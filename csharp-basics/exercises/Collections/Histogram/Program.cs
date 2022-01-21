using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Histogram
{
    class Program
    {
        private static string[] _marks;
        private static List<string> menuRange =
            new List<string>{
            "00-09: ", "10-19: ", "20-29: ", "30-39: ", "40-49: ",
            "50-59: ", "60-69: ", "70-79: ", "80-89: ", "90-99: ",
            "  100: " };
        private static Dictionary<string, string> rangeStars = new Dictionary<string, string>();
        private static List<string> _readText = new List<string>();
        private static List<int> _numbers =
            new List<int>{
            0, 9, 10, 19, 20, 29, 30, 39, 40, 49, 50, 59,
            60, 69, 70, 79, 80, 89, 90, 99, 100};
        private static void Main(string[] args)
        {
            SetUp();
            FillScoresList();
            FillDictionary();
            CheckAllScores();
            PrintDictionary();
            Console.ReadKey();
        }

        public static void SetUp()
        {
            string path = @"..//..//midtermscores.txt";
            string[] text = File.ReadAllLines(path);
            string[] marks = Regex.Split(text[0], " ");
            _marks  = marks;
        }

        public static void FillScoresList()
        {
            foreach (string i in _marks)
            {
                _readText.Add(i);
            }
        }

        public static void PrintDictionary()
        {
            foreach (var i in rangeStars)
            {
                Console.WriteLine($"{i.Key}{i.Value}");
            }
        }

        public static void FillDictionary()
        {
            //add "00-09" to rangeStars Dictionary and empty str
            string starCount = "";
            foreach (string s in menuRange)
            {
                rangeStars.Add(s, starCount);
            }
        }

        public static void CheckAllScores()
        {
            foreach (string s in _readText)
            {
                FillDictStars(s);
            }
        }

        public static void FillDictStars(string i)
        {
            if (int.Parse(i) == 100)
            {
                rangeStars["  100: "] += "*";
            }
            else
            {
                int j = 0;
                while (j < 11)
                {
                    int index = j * 2 + 1;
                    if (int.Parse(i) <= _numbers[index])
                    {
                        rangeStars[$"{j}0-{j}9: "] += "*";
                        j = 11;
                    }
                    j++;
                }
            }
        }
    }
}
