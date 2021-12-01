namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance in meters:");
            string inputDistance = Console.ReadLine();
            Console.WriteLine("Input hour:");
            string inputHours = Console.ReadLine();
            Console.WriteLine("Input minutes:");
            string inputMin = Console.ReadLine();
            Console.WriteLine("Input seconds:");
            string inputSec = Console.ReadLine();

            double inputHoursI = double.Parse(inputHours);
            double inputMinD = double.Parse(inputMin);
            double inputSecD = double.Parse(inputSec);
            double inputDistanceI = double.Parse(inputDistance);
            
            ConverterMS(inputDistanceI, inputHoursI, inputMinD, inputSecD);
            ConverterKmH(inputDistanceI, inputHoursI, inputMinD, inputSecD);
            ConverterMH(inputDistanceI, inputHoursI, inputMinD, inputSecD);

            static void ConverterMS(double distance, double hour, double min, double sec)
            {
                double minConst = 60;
                double allInSeconds = hour * minConst * minConst + min * minConst + sec;
                double speedMS = distance / allInSeconds;
                Console.WriteLine("Your speed in meters/second is " + speedMS);
            }
            
            static void ConverterMH(double distance, double hour, double min, double sec) 
            {
                double minConst = 60;
                double distanceMH = distance / 1609;
                double allInHours = hour + min / minConst + (sec / (minConst * minConst));
                double speedMH = distanceMH / allInHours;
                Console.WriteLine("Your speed in miles/h is " + speedMH);
            }

            static void ConverterKmH(double distance, double hour, double min, double sec)
            {
                double minConst = 60;
                double distanceKm = distance / 1000;
                double allInHours = hour + min / minConst + (sec / (minConst * minConst));
                double speedKmH = distanceKm / allInHours;
                Console.WriteLine("Your speed in km/h is " + speedKmH);
            }
        }
    }
}
