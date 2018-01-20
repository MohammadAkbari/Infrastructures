using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicQuestionComment
    {
        public ClinicQuestionComment()
        {
            ClinicQuestionCommentVote = new HashSet<ClinicQuestionCommentVote>();
            InverseParentComment = new HashSet<ClinicQuestionComment>();
        }

        public int CommentId { get; set; }
        public bool? Approved { get; set; }
        public string Body { get; set; }
        public int TargetId { get; set; }
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

        public ClinicQuestionComment ParentComment { get; set; }
        public ClinicQuestion Target { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<ClinicQuestionCommentVote> ClinicQuestionCommentVote { get; set; }
        public ICollection<ClinicQuestionComment> InverseParentComment { get; set; }
    }
}
