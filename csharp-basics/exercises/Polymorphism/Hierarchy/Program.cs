using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            animals.Add(new Cat("Snow", "cat", 2.7, 0, "home", "bengal"));
            animals.Add(new Tiger("Ron", "tiger", 110, 20, "north east china"));
            animals.Add(new Mouse("Jerry", "mouse", 0.2, 1, "fields"));
            var food = new List<Food>();
            food.Add(new Meat(2));
            food.Add(new Vegetable(5));

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine(animal.Eat(food[0]));
                Console.WriteLine(animal.Eat(food[1]));
                Console.WriteLine();
            }

            Console.WriteLine("End");
            
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.DisplayAnimal()}");
            }
        }
    }
}