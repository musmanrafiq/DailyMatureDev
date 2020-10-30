using System;
using System.Collections.Generic;

namespace DailyDev.Domain.Business.Models
{
    public class FeedModel
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string Copyright { get; set; }
        public string LastUpdatedDateString { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string ImageUrl { get; set; }
        public string OriginalDocument { get; }
        public ICollection<FeedItemModel> Items { get; set; }
    }

    public class FeedItemModel
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string PublishingDateString { get; set; }
        public DateTime? PublishingDate { get; set; }
        public string Author { get; set; }
        public string Id { get; set; }
        public ICollection<string> Categories { get; set; }
        public string Content { get; set; }
    }
}
