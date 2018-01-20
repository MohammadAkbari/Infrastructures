using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumCategoryMapper
    {
        public int ForumCategoryId { get; set; }
        public int OldForumCategoryId { get; set; }

        public ForumCategory ForumCategory { get; set; }
    }
}
