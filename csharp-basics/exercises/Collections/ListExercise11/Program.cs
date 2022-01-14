using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            var list = new List<string>();
            var strings = new List<string> {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};

            //TODO: Add 10 values to list
            for (int i = 0; i < strings.Count; i++)
            {
                list.Add(strings[i]);
            }

            //TODO: Add new value at 5th position
            list.Insert(4, "55");

            //TODO: Change value at last position (Calculate last position programmatically)
            list[list.Count - 1] = "changed";

            //TODO: Sort your list in alphabetical order
            list.Sort();

            //TODO: Check if your list contains "Foobar" element
            if (list.IndexOf("Foobar") != -1)
            {
                Console.WriteLine("List contains element");
            }
            else
            {
                Console.WriteLine("List does not contain element");
            }

            //TODO: Print each element of list using loop
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
