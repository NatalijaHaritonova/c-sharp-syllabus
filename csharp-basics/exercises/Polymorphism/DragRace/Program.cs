using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            string winner = "";
            int carSpeed = 0;
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Tesla());
            cars.Add(new VW());
            cars.Add(new Subaru());

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 1)
                    {
                        car.StartEngine();
                        car.SpeedUp(5);
                    }
                    if (i == 3)
                    {
                        if (car is INitro boostable)
                        {
                            boostable.UseNitrousOxideEngine();
                            continue;
                        }
                    }
                    car.SpeedUp(20);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.GetType().Name}: {car.ShowCurrentSpeed()}");
                if (int.Parse(car.ShowCurrentSpeed()) > carSpeed)
                {
                    carSpeed = int.Parse(car.ShowCurrentSpeed());
                    winner = car.GetType().Name;
                }
            }

            Console.WriteLine($"The winner is {winner} with speed {carSpeed} km/h!");
        }
    }
}