using System.ComponentModel.DataAnnotations;

namespace DailyDev.Domain.Models
{
    public class SiteModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Priority { get; set; } = 1;
    }
}
