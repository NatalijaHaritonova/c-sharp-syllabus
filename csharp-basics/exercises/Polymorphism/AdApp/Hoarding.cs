namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int numDays;
        private bool _primeLocation;

        public Hoarding(int fee, int days, int rate, bool primeLocation) : base(fee)
        {
            _rate = rate;
            numDays = days;
            _primeLocation = primeLocation;
        }

        public override int Cost() 
        {
            if (_primeLocation)
            {
                return _rate * 2 * numDays + _fee;
            }
            else
            {
                return _rate * numDays + _fee; ;
            }
        }

        public override string ToString() 
        {
            var str = base.ToString();
            str += $"; Hoarding: cost per day={_rate}£H, number of days={numDays}, prime location={_primeLocation}";
            return str;
        }
    }
}