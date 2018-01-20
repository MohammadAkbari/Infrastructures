using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumPostClubPostMapper
    {
        public int ForumPostId { get; set; }
        public int ClubPostId { get; set; }

        public ForumPost ForumPost { get; set; }
    }
}
