namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _cm;
        private int _rate;

        public NewspaperAd(int fee, int rate, int cm) : base(fee)
        {
            _cm = cm;
            _rate = rate;
        }

        public override int Cost()
        {
            return _rate * _cm + _fee;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"; Newspaper: cost per cm of column={_rate}£N, centimeters of column={_cm}";
            return str;
        }
    }
}