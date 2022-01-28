namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private int _rate;
        private bool _peakTime;

        public TVAd(int fee, int seconds, int rate, bool peakTime ) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _peakTime = peakTime;
        }
        
        public override int Cost() 
        {
            if (_peakTime)
            {
                return _seconds * _rate * 2 + _fee;
            }
            else
            {
                return _seconds * _rate + _fee;
            }
        }

        public override string ToString() 
        {
            var str = base.ToString();
            str += $"; TV commercial: air time in seconds={_seconds}, cost per second={_rate}£T, peak time={_peakTime}";
            return str;
        }
    }
}