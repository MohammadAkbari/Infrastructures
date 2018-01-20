using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicLog
    {
        public int ForumTopicLogId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionType { get; set; }
        public string ActionUserId { get; set; }
        public string ActionUserName { get; set; }
        public int ForumTopicId { get; set; }
        public string IpAddress { get; set; }
        public string Subject { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public ForumTopic ForumTopic { get; set; }
    }
}
