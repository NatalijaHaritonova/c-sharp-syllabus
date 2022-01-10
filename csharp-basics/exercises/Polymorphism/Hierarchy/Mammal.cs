namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string _livingRegion { get; set; }

        public Mammal(string name, string type, double weight, int foodEaten, string livingRegion) : base(name, type, weight, foodEaten)
        {
            _livingRegion = livingRegion;
        }

        public override string ToString()
        {
            return base.ToString() + $", living region: {_livingRegion}";
        }
    }
}
