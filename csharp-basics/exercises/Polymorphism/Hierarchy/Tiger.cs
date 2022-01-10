namespace Hierarchy
{
    internal class Tiger : Feline
    {
        public Tiger(string name, string type, double weight,
            int foodEaten, string livingRegion) 
            : base (name, type, weight, foodEaten, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "ROOOAAR";
        }

        public override string Eat(Food food)
        {
            if (food is Meat)
            {
                _foodEaten += food._qty;
                return $"{_name} the {_type} ate {food._qty}kg of meat";
            }
            else
            {
                return $"{_type} are not eating that type of food!";
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string DisplayAnimal()
        {
            return $"{_type} [{_name}, {_weight}, {_livingRegion}, {_foodEaten}]";
        }
    }
}
