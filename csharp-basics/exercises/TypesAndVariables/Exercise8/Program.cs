// Write a C# program to convert minutes into a number of years and days.
namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string minutesString;
            int minutesInDay = 60 * 24;
            int minutesInYear = 60 * 24 * 365;
            minutesString = Console.ReadLine();
            int minutesInt = int.Parse(minutesString);
            int convertToYears = minutesInt / minutesInYear;
            int remainingMinutes = minutesInt % minutesInYear;
            int converToDays = remainingMinutes / minutesInDay;
            Console.WriteLine("The entered number of minutes corresponds" +
                " to: " + convertToYears + " years and " + converToDays + " days.");

        }
    }
}

