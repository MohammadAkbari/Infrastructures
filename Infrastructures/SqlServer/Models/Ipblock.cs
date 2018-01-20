using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Ipblock
    {
        public int IpblockId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Custom { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public long End { get; set; }
        public string EndIp { get; set; }
        public long Start { get; set; }
        public string StartIp { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
