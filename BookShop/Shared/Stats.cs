using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Shared
{
    public class Stats
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Visits { get; set; }
        public DateTime? LastVisit { get; set; }
    }
}