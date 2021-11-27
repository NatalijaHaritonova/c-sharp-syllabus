namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            static double ConverterMS(int distance, int hour, int minutes, int seconds)
            {
                int minuteConst = 60;
                int allInSecondsI = hour * minuteConst * minuteConst + minutes * minuteConst + seconds;
                double speedMS = (double)distance / (double)allInSecondsI;
                return speedMS;
            }
            static double ConverterMH(int distance, int hour, int minutes, int seconds) 
            {
                int minuteConst = 60;
                double minuteConstD = 60;
                double distanceMH = (double)distance / 1609;
                double allInHours = (double)hour + (double)minutes / minuteConstD + ((double)seconds / (minuteConst * minuteConstD));
                double speedMH = distanceMH / allInHours;
                return speedMH;
            }
            static double ConverterKmH(int distance, int hour, int minutes, int seconds)
            {
                int minuteConst = 60;
                double minuteConstD = 60;
                double distanceKm = (double)distance / 1000;
                double allInHours = (double)hour + (double)minutes / minuteConstD + ((double)seconds / (minuteConst * minuteConstD));
                double speedKmH = distanceKm / allInHours;
                return speedKmH;
            }
            Console.WriteLine("Input distance in meters:");
            string inputDataDistance = Console.ReadLine();
            Console.WriteLine("Input hour:");
            string inputDataHours = Console.ReadLine();
            Console.WriteLine("Input minutes:");
            string inputDataMinutes = Console.ReadLine();
            Console.WriteLine("Input seconds:");
            string inputDataSeconds = Console.ReadLine();

            int inputDataHoursI = int.Parse(inputDataHours);
            int inputDataMinutesI = int.Parse(inputDataMinutes);
            int inputDataSecondsI = int.Parse(inputDataSeconds);
            int inputDataDistanceI = int.Parse(inputDataDistance);

            double result1 = ConverterMS(inputDataDistanceI, inputDataHoursI, inputDataMinutesI, inputDataSecondsI);
            double result2 = ConverterKmH(inputDataDistanceI, inputDataHoursI, inputDataMinutesI, inputDataSecondsI);
            double result3 = ConverterMH(inputDataDistanceI, inputDataHoursI, inputDataMinutesI, inputDataSecondsI);
            
            Console.WriteLine("Your speed in meters/second is " + result1);
            Console.WriteLine("Your speed in km/h is " + result2);
            Console.WriteLine("Your speed in miles/h is " + result3);
        }
    }
}
