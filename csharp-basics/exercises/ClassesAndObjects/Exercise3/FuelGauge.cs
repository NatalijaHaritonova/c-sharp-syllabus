namespace Exercise3
{
    public class FuelGauge
    {
        public double _litersOfFuel;

        public FuelGauge(double fuelL)
        {
            _litersOfFuel = fuelL;
        }

        public double AmountOfFuel()
        {
            return _litersOfFuel;
        }

        public void Increment(double litters)
        {
            for (int i = 0; i < litters; i++)
            {
                if (_litersOfFuel < 70)
                {
                    _litersOfFuel += 1;
                }
                else
                {
                    Console.WriteLine("Fuel tank is full");
                    break;
                }
            }
        }

        public void Decrement()
        {
            if ( _litersOfFuel > 0)
            {
                _litersOfFuel -= 1;
            }
            else
            {
                Console.WriteLine("Fuel tank is empty");
            }
        }

        public bool FuelCheck()
        {
            if (_litersOfFuel > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
