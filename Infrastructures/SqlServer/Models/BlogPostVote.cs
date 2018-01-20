using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogPostVote
    {
        public int BlogPostVoteId { get; set; }
        public int BlogPostId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }

        public BlogPost BlogPost { get; set; }
        public AspNetUsers User { get; set; }
    }
}
