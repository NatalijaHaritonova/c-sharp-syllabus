using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Eyes, Teeth, Hair;
            int Age, Height, Weight;
            double HeightCm, WeightKg;

            Name = "Zed A. Shaw";
            Age = 35;
            Height = 74;  // inches
            HeightCm = Height * 2.54;
            HeightCm = (double)System.Math.Round(HeightCm, 2);
            Weight = 180; // lbs
            WeightKg = Weight * 0.453592;
            WeightKg = (double)System.Math.Round(WeightKg, 2);
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + HeightCm + " centimeter tall.");
            Console.WriteLine("He's " + WeightKg + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + Age + ", " + HeightCm + ", and " + WeightKg
                               + " I get " + (Age + HeightCm + WeightKg) + ".");
            Console.ReadKey();
        }
    }
}