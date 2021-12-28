using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<string> videoStore = new List<string>();
        private static Video theMatrix = new Video("The Matrix");
        private static Video godWars = new Video("Godfather II");
        private static Video starWars = new Video("Star Wars Episode IV: A New Hope");

        public VideoStore()
        {
            
        }

        public void AddVideo(string title)
        {
            videoStore.Add(title);
        }
        
        public void Checkout(string title)
        {
            if (ChooseVideo(title)._checkedOut == false)
            {
                ChooseVideo(title).BeingCheckedOut();
            }
            else
            {
                Console.WriteLine("Movie is already rented");
            }
        }

        public void ReturnVideo(string title)
        {
            if (ChooseVideo(title)._checkedOut == true)
            {
                ChooseVideo(title).BeingReturned();
            }
            else
            {
                Console.WriteLine("Are you sure this movie is from our store?");
            }
        }

        public void TakeUsersRating(int rating, string title)
        {
            ChooseVideo(title).ReceivingRating(rating);
        }

        public void ListInventory()
        {
            foreach (string i in videoStore)
            {
                Console.WriteLine(ChooseVideo(i).ToString());
            }
        }

        public Video ChooseVideo(string title)
        {
            if (theMatrix._title == title)
            {
                return theMatrix;
            }
            else if (godWars._title == title)
            {
                return godWars;
            }
            else
            {
                return starWars;
            }
        }
    }
}
