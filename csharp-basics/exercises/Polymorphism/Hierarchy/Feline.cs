namespace Hierarchy
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, string type, double weight,
            int foodEaten, string livingRegion) : base (name,
                type, weight, foodEaten, livingRegion)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
