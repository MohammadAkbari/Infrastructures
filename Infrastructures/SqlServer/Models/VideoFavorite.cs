using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoFavorite
    {
        public int VideoFavoriteId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public int VideoId { get; set; }
        public string IpAddress { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public AspNetUsers User { get; set; }
        public Video Video { get; set; }
    }
}
