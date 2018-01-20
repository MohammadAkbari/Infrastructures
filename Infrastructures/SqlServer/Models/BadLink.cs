using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BadLink
    {
        public int BadLinkId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Link { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
