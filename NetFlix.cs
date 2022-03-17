using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
namespace TestingDemoProject
{
    class NetFlix
    {
        public decimal SubscriptionCost { get; set; }
        public string SubscriptionType { get; set; }

        public const decimal gst = 0.18m;

        public List<string> Genres { get {

                return new List<string>() { "SciFi", "Romantic", "Thriller", "Action" };
            }  }

        public decimal BuySubscription(decimal amount)
        {
            var val = amount + amount * gst;
            return val;
        }
        public List<string> GetMoviesList(string genre)
        {
            List<string> list = null;
            
            if (Genres.Contains(genre))
            {
                //
                
            }
            else
            {
                
                list = new List<string>() { "Empty" };
            }
            return list;
           
        }

        

       


    }
}
