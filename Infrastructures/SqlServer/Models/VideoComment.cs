using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoComment
    {
        public VideoComment()
        {
            InverseParentComment = new HashSet<VideoComment>();
            VideoCommentVote = new HashSet<VideoCommentVote>();
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
        public DateTime? UpdatedOn { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }
        public int TargetId { get; set; }

        public VideoComment ParentComment { get; set; }
        public Video Target { get; set; }
        public AspNetUsers User { get; set; }
        public VideoCommentMapper VideoCommentMapper { get; set; }
        public ICollection<VideoComment> InverseParentComment { get; set; }
        public ICollection<VideoCommentVote> VideoCommentVote { get; set; }
    }
}
