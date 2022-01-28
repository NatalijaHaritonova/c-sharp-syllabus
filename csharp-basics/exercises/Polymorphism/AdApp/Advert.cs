namespace AdApp
{
    public class Advert
    {
        public int _fee { get; set; }

        public Advert() 
        {
            _fee = 0;
        }

        public Advert(int fee) 
        {
            _fee = fee;
        }

        public void SetFee(int fee) 
        {
            _fee = fee;
        }

        public virtual int Cost() 
        {
            return _fee;
        }

        public override string ToString() 
        {
            return "\nAdvert: Fee=" + _fee;
        }
    }
}