using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumPostVote
    {
        public int ForumPostId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedOn { get; set; }

        public ForumPost ForumPost { get; set; }
        public AspNetUsers User { get; set; }
    }
}
