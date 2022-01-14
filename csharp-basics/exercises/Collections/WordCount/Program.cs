using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counting lines
            string filePath = @"C:\CODELEX\csharp\c-sharp-syllabus-main\csharp-basics\exercises\Collections\WordCount\lear.txt";
            List <string> text = new List<string>();
            text = File.ReadAllLines(filePath).ToList();
            int lines = text.Count;
            //Counting words
            string wordStr = "";
            for (int i = 0; i < text.Count; i++)
            {
                wordStr += text[i] + " ";
            }
            string[] wordList = Regex.Replace(wordStr, @"\s+", " ").Trim().Split(' ', '\'');
            int words = wordList.Length;
            //Counting chars
            List<char> charList = new List<char>();
            for (int i = 0; i < text.Count; i++)
            {
                char[] charStr = text[i].ToCharArray();
                foreach (char c in charStr)
                {
                    charList.Add(c);
                }
            }
            int chars = charList.Count;
            //Output
            Console.WriteLine("Lines = " + lines);
            Console.WriteLine("Words = " + words);
            Console.WriteLine("Chars = " + chars);
            Console.ReadLine();
        }
    }
}
