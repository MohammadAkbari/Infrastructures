using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoLog
    {
        public int VideoLogId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionType { get; set; }
        public string ActionUserId { get; set; }
        public string ActionUserName { get; set; }
        public string IpAddress { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public int VideoId { get; set; }

        public Video Video { get; set; }
    }
}
