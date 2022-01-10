namespace Hierarchy
{
    internal class Cat : Feline
    {
        private string _breed;

        public Cat(string name, string type, double weight,
            int foodEaten, string livingRegion, string breed)
            : base (name, type, weight, foodEaten, livingRegion)
        {
            _breed = breed;
        }

        public override string MakeSound()
        {
            return "Meeeow";
        }

        public override string Eat(Food food)
        {
            _foodEaten += food._qty;
            if (food is Vegetable)
            {
                return $"{_name} the {_type} ate {food._qty}kg of vegetables";
            }
            else
            {
                return $"{_name} the {_type} ate {food._qty}kg of meat";
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", breed: {_breed}.";
        }

        public override string DisplayAnimal()
        {
            return $"{_type} [{_name}, {_breed}, {_weight}, {_livingRegion}, {_foodEaten}]";
        }
    }
}
