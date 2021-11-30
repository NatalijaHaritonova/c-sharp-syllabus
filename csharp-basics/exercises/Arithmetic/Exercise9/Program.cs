namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            BodyMassIndex(62, 156);
        }

        private static void BodyMassIndex(double weight, double height)
        {
            double poundsCoff = 2.205;
            double weightP = weight * poundsCoff;
            double inchCoff = 2.54;
            double heightI = height / inchCoff;
            double indexBMI = weightP * 703 / Math.Pow(heightI, 2);

            if (indexBMI > 18.5 && indexBMI < 25)
            {
                Console.WriteLine("person's weight is optimal");
            }
            else if (indexBMI < 18.5)
            {
                Console.WriteLine("person's weight is underweight");
            }
            else if (indexBMI > 25)
            {
                Console.WriteLine("person's weight is overweight");
            }
        }
    }
}