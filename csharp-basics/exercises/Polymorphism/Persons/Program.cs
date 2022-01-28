using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Employee("John", "Jegger", "Lake Street 45", 16161616, "Artist");
            var b = new Student("Sam", "Rod", "New York", 15151515, 8.3);
            var c = new Student(8.3);
            var d = new Employee("Police Officer");
            a.Display();
            Console.WriteLine();
            b.Display();
            Console.WriteLine();
            c.Display();
            Console.WriteLine();
            d.Display();
            Console.ReadLine();
        }
    }
}