using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Yellow");
            colors.Add("Black");
            colors.Add("Pink");

            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine(colors[i]);
            }
            Console.ReadKey();
        }
    }
}
