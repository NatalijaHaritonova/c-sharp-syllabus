namespace Hierarchy
{
    public abstract class Food
    {
        public int _qty { get; set; }

        public Food(int qty)
        {
            _qty = qty;
        }
    }
}
