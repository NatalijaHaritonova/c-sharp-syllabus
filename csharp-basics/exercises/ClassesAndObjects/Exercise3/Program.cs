namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge(0);
            Odometer odometer = new Odometer(0, fuelGauge);
            fuelGauge.Increment(2);

            for (int i = 0; i < 21; i++)
            {
                odometer.Drive();
                Console.WriteLine("Current amount of fuel:" + fuelGauge.AmountOfFuel());
                Console.WriteLine("Current mileage:" + odometer.CurrentMileage());
            }
        }
    }
}
