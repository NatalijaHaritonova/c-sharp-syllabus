using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        public List<Advert> campaign { get; }

        public Campaign() 
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            campaign.Add(a);
        }

        public int GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            return "Advert Campaign" + campaign + "\nTotal Cost = "+ GetCost();
        }
    }
}