using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumPostLog
    {
        public int ForumPostLogId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionType { get; set; }
        public string ActionUserId { get; set; }
        public string ActionUserName { get; set; }
        public int ForumPostId { get; set; }
        public string IpAddress { get; set; }
        public string Message { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public ForumPost ForumPost { get; set; }
    }
}
