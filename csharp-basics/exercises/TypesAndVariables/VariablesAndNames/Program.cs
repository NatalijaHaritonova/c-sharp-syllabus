using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars;
            int drivers;
            int carsNotDriven;
            int seatsInACar;
            double passengers;
            double carsDriven;
            double carPoolCapacity;
            double averagePassengersPerCar;

            cars = 100;
            seatsInACar = 4;
            drivers = 28;
            passengers = 90;
            carsNotDriven = cars - drivers;
            carsDriven = drivers;
            carPoolCapacity = drivers * seatsInACar;
            averagePassengersPerCar = passengers / carsDriven;
            averagePassengersPerCar = (double)System.Math.Round(averagePassengersPerCar, 2);


            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carPoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}