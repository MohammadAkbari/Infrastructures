using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicMapper
    {
        public int ForumTopicId { get; set; }
        public int OldForumTopicId { get; set; }

        public ForumTopic ForumTopic { get; set; }
    }
}
