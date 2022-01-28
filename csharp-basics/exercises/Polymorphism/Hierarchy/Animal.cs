namespace Hierarchy
{
    public abstract class Animal
    {
        public string _name { get; set; }
        public string _type { get; set; }
        public double _weight { get; set; }
        public int _foodEaten { get; set; }

        public Animal(string name, string type, double weight, int foodEaten)
        {
            _name = name;
            _type = type;
            _weight = weight;
            _foodEaten = foodEaten;
        }

        public abstract string MakeSound();

        public abstract string Eat(Food food);

        public override string ToString()
        {
            return $"Type: {_type}, name: {_name}, weight: {_weight}kg";
        }

        public abstract string DisplayAnimal();
    }
}
