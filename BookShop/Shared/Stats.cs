using System.ComponentModel.DataAnnotations;

namespace BookShop.Shared
{
    public class Stats
    {
        [Key]
        public string Email { get; set; }
        public int Visits { get; set; }
        public DateTime? LastVisit { get; set; }
    }
}