using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoLog
    {
        public int PhotoLogId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionType { get; set; }
        public string ActionUserId { get; set; }
        public string ActionUserName { get; set; }
        public string IpAddress { get; set; }
        public int PhotoId { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public Photo Photo { get; set; }
    }
}
