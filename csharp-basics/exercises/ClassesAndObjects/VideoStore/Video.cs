using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private List<int> _rating = new List<int>();
        public string Title { get; set; }
        private int _countLiked = 0;
        public bool _checkedOut { get; set; }

        public Video(string title)
        {
            Title = title;
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
            _rating.Add(rating);
            if (rating > 5)
            {
                _countLiked++;
            }
            double percentage = _countLiked * 100 / _rating.Count;

            if (_countLiked > 0)
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
            double total = _rating.Sum(x => Convert.ToInt32(x));
            return Math.Round(total/_rating.Count, 1);
        }

        public bool NotAvailable()
        {
            return _checkedOut;
        }

        public override string ToString()
        {
            return $"{Title}  rating: {AverageRating()} : Not available : {NotAvailable()}";
        }
    }
}
