using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdZone
    {
        public AdZone()
        {
            Ad = new HashSet<Ad>();
        }

        public int AdZoneId { get; set; }
        public int AdPageId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int MaxAd { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Width { get; set; }
        public int Zone { get; set; }
        public int AdZoneType { get; set; }
        public int Height { get; set; }

        public AdPage AdPage { get; set; }
        public ICollection<Ad> Ad { get; set; }
    }
}
