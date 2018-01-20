using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumPostEverybodyCanTalkAboutMapper
    {
        public int ForumPostId { get; set; }
        public int CommentId { get; set; }

        public ForumPost ForumPost { get; set; }
    }
}
