using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumPostMapper
    {
        public int ForumPostId { get; set; }
        public int OldForumPostId { get; set; }

        public ForumPost ForumPost { get; set; }
    }
}
