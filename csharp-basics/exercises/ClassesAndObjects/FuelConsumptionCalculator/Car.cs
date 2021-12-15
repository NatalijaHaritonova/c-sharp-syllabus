namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _endKm;
        private double _liters;
        public Car(double startOdo)
        {
        }

        public double CalculateConsumption()
        {
            return _endKm / _liters;
        }

        public double ConsumptionPer100Km()
        {
            return _liters * 100 / _endKm;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(double mileage, double liters)
        {
            _endKm = mileage;
            _liters = liters;
        }
    }
}
