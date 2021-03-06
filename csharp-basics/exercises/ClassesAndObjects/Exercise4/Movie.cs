using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Movie
    {
        public string _title;
        public string _studio;
        public string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public string Display()
        {
            return $"{_title} {_studio} {_rating}";
        }
    }
}
