using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdVideoPlay
    {
        public int AdVideoPlayId { get; set; }
        public int AdVideoId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public DateTime PlayedOn { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public AdVideo AdVideo { get; set; }
    }
}
