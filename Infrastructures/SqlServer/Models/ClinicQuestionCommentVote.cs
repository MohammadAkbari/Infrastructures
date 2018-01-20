using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicQuestionCommentVote
    {
        public int CommentVoteId { get; set; }
        public int CommentId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }
        public int VoteType { get; set; }

        public ClinicQuestionComment Comment { get; set; }
        public AspNetUsers User { get; set; }
    }
}
