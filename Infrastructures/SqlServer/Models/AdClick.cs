using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdClick
    {
        public int AdClickId { get; set; }
        public int AdId { get; set; }
        public DateTime ClickedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public Ad Ad { get; set; }
    }
}
