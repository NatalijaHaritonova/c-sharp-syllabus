using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = @"..//..//flights.txt";
        private static List<string> readText = new List<string>(File.ReadAllLines(Path));
        private static Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        private static HashSet<string> startPointC = new HashSet<string>();
        private static string InitialPoint = "";
        private static readonly List<string> _route = new List<string>();
        private static FPlanner a = new FPlanner(dict);

        private static void Main(string[] args)
        {
            FillDictionary();
            StartMenu();
        }

        public static void StartMenu()
        {
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"{a.ShowAllCities()}");
                    Console.WriteLine("To select a city from which you would like to start press 1, to exit press #");
                    if (Console.ReadLine() == "1")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter city name: ");
                        string startCity = Console.ReadLine();
                        InitialPoint = startCity;
                        _route.Add(startCity + " -> ");
                        if (dict.ContainsKey(startCity))
                        {
                            ShowCityList(startCity);
                            ChooseNext();
                        }
                        else
                        {
                            Console.WriteLine("Error reading city name.Try again!");
                            Console.ReadKey();
                        }
                    }
                    break;
                case "#":
                    break;
            }
        }

        public static void FillDictionary()
        {
            foreach (string i in readText)
            {
                var city = Regex.Split(i, " -> ");

                if (dict.ContainsKey(city[0]))
                {
                    dict[city[0]].Add(city[1]);
                }
                else
                {
                    dict.Add(city[0].ToString(), new List<string> { $"{city[1]}" });
                }
                startPointC.Add(city[0]);
            }
        }

        public static void ShowCityList(string city)
        {
            Console.WriteLine();
            Console.WriteLine("From the city you have chosen you can fly to: ");
            Console.WriteLine($"{a.ShowAvailableCities(city)}");
        }

        public static void ChooseNext()
        {
            Console.WriteLine();
            Console.WriteLine("Enter your next stop: ");
            string nextCity = Console.ReadLine();
            _route.Add(nextCity);

            if (nextCity == InitialPoint)
            {
                Console.WriteLine();
                Console.Write("Your rote: ");
                foreach (string i in _route)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Console.WriteLine("Enjoy your trip. Bye!");
                Console.ReadKey();
            }
            else
            {
                ShowCityList(nextCity);
                _route.Add(" -> ");
                ChooseNext();
            }
        }
    }
}
