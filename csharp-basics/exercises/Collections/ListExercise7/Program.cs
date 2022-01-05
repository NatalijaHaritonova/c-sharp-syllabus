using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            if (colors.IndexOf("White") >= 0)
            {
                Console.WriteLine("List contains mentioned element");
            }
            else
            {
                Console.WriteLine("List do not contains mentioned element");
            }
            Console.ReadKey();
        }
    }
}
