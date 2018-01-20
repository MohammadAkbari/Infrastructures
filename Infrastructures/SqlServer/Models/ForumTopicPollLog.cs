using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicPollLog
    {
        public int ForumTopicPollLogId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionType { get; set; }
        public string ActionUserId { get; set; }
        public string ActionUserName { get; set; }
        public string Content { get; set; }
        public int ForumTopicPollId { get; set; }
        public string IpAddress { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public ForumTopicPoll ForumTopicPoll { get; set; }
    }
}
