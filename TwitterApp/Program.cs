using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new Twitter
            {
                OAuthCustomerKey = "OAuth Customer Key",
                OAuthCustomerSecret = "OAuth Customer Secret"
            };
            IEnumerable<string> twitts = twitter.GetTwitts("", 100).Result;
            foreach (var t in twitts)
            {
                Console.WriteLine(t + "\n");
            }
            Console.ReadKey();
        }
    }
}
