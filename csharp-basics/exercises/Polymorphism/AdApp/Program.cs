using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200, false));
            c.AddAdvert(new NewspaperAd(0, 30, 20));
            c.AddAdvert(new TVAd(50000, 1000, 30, true));
            c.AddAdvert(new Poster(30, 45, 2, 2));

            foreach (var add in c.campaign)
            {
                
                Console.WriteLine(add.ToString());
                Console.WriteLine($"Cost: {add.Cost()}£");
            }
        }
    }
}