namespace AdApp
{
    public class Poster : Advert
    {
        private int _hight;
        private int _widht;
        private int _copies;
        private int _rate;

        public Poster( int hight, int width, int copies, int rate)
        {
            _hight = hight;
            _widht = width;
            _copies = copies;
            _rate = rate;
        }

        public override int Cost()
        {
            return _hight * _widht * _copies * _rate;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"; Poster: hight={_hight}cm, width={_widht}cm, number of copies={_copies}, cost per copy={_rate}£P";
            return str;
        }
    }
}
