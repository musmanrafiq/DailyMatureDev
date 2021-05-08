using System.ComponentModel.DataAnnotations;

namespace DailyDev.Domain.Models
{
    public class TempLink
    {
        [Key]
        public int Id { get; set; }
        public string FeedPostId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Author { get; set; }
    }
}
