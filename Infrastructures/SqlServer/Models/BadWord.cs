using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BadWord
    {
        public int BadWordId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Word { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool Delivered { get; set; }
        public bool Dropped { get; set; }
        public bool Opened { get; set; }
    }
}
