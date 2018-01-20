using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicFavorite
    {
        public int ForumTopicId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastVisitedPostId { get; set; }

        public ForumTopic ForumTopic { get; set; }
        public AspNetUsers User { get; set; }
    }
}
