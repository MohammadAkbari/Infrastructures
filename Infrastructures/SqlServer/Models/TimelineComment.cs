using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class TimelineComment
    {
        public TimelineComment()
        {
            InverseParentComment = new HashSet<TimelineComment>();
            TimelineCommentVote = new HashSet<TimelineCommentVote>();
        }

        public int CommentId { get; set; }
        public bool? Approved { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int Dislikes { get; set; }
        public string IpAddress { get; set; }
        public int Likes { get; set; }
        public int? ParentCommentId { get; set; }
        public string ReplyToNickName { get; set; }
        public int TargetId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }

        public TimelineComment ParentComment { get; set; }
        public Timeline Target { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<TimelineComment> InverseParentComment { get; set; }
        public ICollection<TimelineCommentVote> TimelineCommentVote { get; set; }
    }
}
