using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = @"..//..//flights.txt";
        private static string InitialPoint = "";
        private static readonly List<string> _route = new List<string>();

        private static void Main(string[] args)
        {
            var readText = new List<string>(File.ReadAllLines(Path));
            var dict = new Dictionary<string, List<string>>();
            var startPointC = new HashSet<string>();
            //Fill dictionary
            foreach (string i in readText)
            {
                var city = Regex.Split(i, " -> ");

                if (dict.ContainsKey(city[0]))
                {
                    dict[city[0]].Add(city[1]);
                }
                else
                {
                    dict.Add(city[0].ToString(), new List<string> {$"{city[1]}"});
                }
                startPointC.Add(city[0]);
            }

            //Menu
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            switch (Console.ReadLine())
            {
                case "1":
                    foreach (var i in dict)
                    {
                        Console.WriteLine($"{i.Key}\n");
                    }
                    Console.WriteLine();
                    Console.ReadKey();
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

            void ShowCityList(string city)
            {
                Console.WriteLine();
                Console.WriteLine("From the city you have chosen you can fly to: ");
                foreach (string name in dict[city])
                {
                    Console.WriteLine(name);
                }
            }

            void ChooseNext()
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
}
