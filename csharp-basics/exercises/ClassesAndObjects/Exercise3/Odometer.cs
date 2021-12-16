namespace Exercise3
{
    public class Odometer
    {
        private double _mileage;
        private double _count = 0;
        private readonly FuelGauge _fuelGauge;

        public Odometer(double kilometers, FuelGauge fuelGauge)
        {
            _mileage = kilometers;
            _fuelGauge = fuelGauge;
        }

        public double CurrentMileage()
        {
            return _mileage;
        }

        public void Drive()
        {
            if (_mileage < 999.999 && _fuelGauge.FuelCheck() == true)
            {
                _mileage += 1;
                _count += 1;
                
                if (_count == 10)
                {
                    _count -= 10;
                    _fuelGauge.Decrement();
                }
            }
            else if (_mileage < 999.999 && _fuelGauge.FuelCheck() == false)
            {
                Console.WriteLine("Not enough fuel");
            }
            else
            {
                _mileage = 0;
            }
        }
    }
}
