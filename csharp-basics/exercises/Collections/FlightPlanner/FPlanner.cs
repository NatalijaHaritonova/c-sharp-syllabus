using System.Collections.Generic;

namespace FlightPlanner
{
    public class FPlanner
    {

        private static Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        public FPlanner(Dictionary<string, List<string>> fligths)
        {
            dict = fligths;
        }

        public string ShowAllCities()
        {
            string list = "";
            foreach (var i in dict)
            {
                list += $"{i.Key}\n";
            }
            return list;
        }

        public string ShowAvailableCities(string city)
        {
            string list = "";
            foreach (string name in dict[city])
            {
                list += $"{name}\n";
            }
            return list;
        }
    }
}
