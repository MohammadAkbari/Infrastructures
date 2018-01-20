using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdVideoClick
    {
        public int AdVideoClickId { get; set; }
        public int AdVideoId { get; set; }
        public DateTime ClickedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public AdVideo AdVideo { get; set; }
    }
}
