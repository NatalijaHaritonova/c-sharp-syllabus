using System;
using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..//..//lear.txt";
            List<string >text = new List<string>(File.ReadAllLines(filePath));

            Console.WriteLine("Lines = " + new WCount().LineCount(text));
            Console.WriteLine("Words = " + new WCount().WordCount(text));
            Console.WriteLine("Chars = " + new WCount().CharCount(text));
            Console.ReadLine();
        }
    }
}
