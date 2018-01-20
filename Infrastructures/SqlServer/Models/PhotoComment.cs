using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoComment
    {
        public PhotoComment()
        {
            InverseParentComment = new HashSet<PhotoComment>();
            PhotoCommentVote = new HashSet<PhotoCommentVote>();
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
        public int TargetId { get; set; }
        public string ReplyToNickName { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }

        public PhotoComment ParentComment { get; set; }
        public Photo Target { get; set; }
        public AspNetUsers User { get; set; }
        public PhotoCommentMapper PhotoCommentMapper { get; set; }
        public ICollection<PhotoComment> InverseParentComment { get; set; }
        public ICollection<PhotoCommentVote> PhotoCommentVote { get; set; }
    }
}
