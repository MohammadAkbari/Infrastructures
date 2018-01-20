using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicMember
    {
        public int ForumTopicMemberId { get; set; }
        public bool? Accept { get; set; }
        public string CallerId { get; set; }
        public bool Deleted { get; set; }
        public int ForumTopicId { get; set; }
        public DateTime InvitationDate { get; set; }
        public DateTime? JoinDate { get; set; }
        public string MemberId { get; set; }
        public string Message { get; set; }

        public AspNetUsers Caller { get; set; }
        public ForumTopic ForumTopic { get; set; }
        public AspNetUsers Member { get; set; }
    }
}
