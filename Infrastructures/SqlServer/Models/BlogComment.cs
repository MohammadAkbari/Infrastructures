using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogComment
    {
        public BlogComment()
        {
            BlogCommentVote = new HashSet<BlogCommentVote>();
            InverseParentComment = new HashSet<BlogComment>();
        }

        public int CommentId { get; set; }
        public bool? Approved { get; set; }
        public int TargetId { get; set; }
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

        public BlogComment ParentComment { get; set; }
        public BlogPost Target { get; set; }
        public AspNetUsers User { get; set; }
        public BlogCommentMapper BlogCommentMapper { get; set; }
        public ICollection<BlogCommentVote> BlogCommentVote { get; set; }
        public ICollection<BlogComment> InverseParentComment { get; set; }
    }
}
