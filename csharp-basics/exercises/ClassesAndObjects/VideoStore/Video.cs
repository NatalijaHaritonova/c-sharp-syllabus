using System;
using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        public double _rating {get; set;} = 0;
        public string _title { get; set; }
        public int _countiked { get; set; } = 0;
        public int _count { get; set; } = 0;
        public bool _checkedOut { get; set; }

        public Video(string title)
        {
            _title = title;
        }

        public void BeingCheckedOut()
        {
            _checkedOut = true;
        }

        public void BeingReturned()
        {
            _checkedOut = false;
        }

        public void ReceivingRating(int rating)
        {
            _rating += rating;
            if (rating > 5)
            {
                _countiked++;
                _count++;
            }
            else
            {
                _count++;
            }
            double percentage = _countiked * 100 / _count;
            if (_countiked > 0)
            {
                Console.WriteLine($"{percentage}% liked this movie");
            }
            else
            {
                Console.WriteLine("No one liked this movie yet");
            }
        }

        public double AverageRating()
        {
            return Math.Round(_rating / _count, 1);
        }

        public bool Available()
        {
            if (_checkedOut)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return $"{_title}  rating: {AverageRating()} : available : {Available()}";
        }
    }
}
