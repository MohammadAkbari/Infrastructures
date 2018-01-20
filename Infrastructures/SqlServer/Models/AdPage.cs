using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdPage
    {
        public AdPage()
        {
            AdZone = new HashSet<AdZone>();
        }

        public int AdPageId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int Page { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<AdZone> AdZone { get; set; }
    }
}
