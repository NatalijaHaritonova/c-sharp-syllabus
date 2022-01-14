using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = GetMenu();
            if (userChoice == 1)
            {
                CalculateCircleArea();
            }
            else if (userChoice == 2)
            {
                CalculateRectangleArea();
            }
            else if (userChoice == 3)
            {
                CalculateTriangleArea();
            }
            else if (userChoice == 4)
            {
                Environment.Exit(0);
            }
        }

        public static int GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Not in range of 1-4. Please restart program to try again!");
                Console.ReadKey();
            }
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            decimal radius = decimal.Parse(Console.ReadLine());

            if (radius > 0)
            {
                Console.WriteLine("The circle's area is " +
                   Geometry.AreaOfCircle(radius));
                Console.ReadKey();
            }
            else if (radius <= 0)
            {
                Console.WriteLine("Radius must be > 0.");
                Console.ReadKey();
            }
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length? ");
            decimal length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter width? ");
            decimal width = decimal.Parse(Console.ReadLine());

            if (length > 0 && width > 0)
            {
                Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
                Console.ReadKey();
            }
            else if (length <= 0 || width <= 0)
            {
                Console.WriteLine("Length and width must be > 0.");
                Console.ReadKey();
            }
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter length of the triangle's base? ");
            decimal ground = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter triangle's height? ");
            decimal height = decimal.Parse(Console.ReadLine());

            if (ground > 0 && height > 0)
            {
                Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
                Console.ReadKey();
            }
            else if (ground <= 0 || height <= 0)
            {
                Console.WriteLine("Ground and height must be > 0.");
                Console.ReadKey();
            }
        }
    }
}
