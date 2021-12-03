namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDayInWorld();

            static void PrintDayInWorld()
            {
                Console.WriteLine("Enter number of day from 0 to 6");
                var input = Console.ReadLine();
                int dayNumber;
                if (int.TryParse(input, out dayNumber))
                {
                    if (dayNumber >= 0)
                    {
                        switch (dayNumber)
                        {
                            case 0:
                                Console.WriteLine("Sunday");
                                break;
                            case 1:
                                Console.WriteLine("Monday");
                                break;
                            case 2:
                                Console.WriteLine("Tuesday");
                                break;
                            case 3:
                                Console.WriteLine("Wednesday");
                                break;
                            case 4:
                                Console.WriteLine("Thursday");
                                break;
                            case 5:
                                Console.WriteLine("Friday");
                                break;
                            case 6:
                                Console.WriteLine("Saturday");
                                break;
                            default:
                                Console.WriteLine("Not a valid day");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a valid day");
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid day");
                }
                   
            }
        }
    }
}