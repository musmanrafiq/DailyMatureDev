using CodeHollow.FeedReader;
using System;
using System.Threading.Tasks;

namespace DailyDev.Infrastructure.Services
{
    public class Class1
    {
        public void doIt()
        {
            var feed = FeedReader.Read("https://www.usmanrafiq.com/feeds/posts/default");

            Console.WriteLine("Feed Title: " + feed.Title);
            Console.WriteLine("Feed Description: " + feed.Description);
            Console.WriteLine("Feed Image: " + feed.ImageUrl);
            // ...
            foreach (var item in feed.Items)
            {
                Console.WriteLine(item.Title + " - " + item.Link);
            }
        }
    }
}
