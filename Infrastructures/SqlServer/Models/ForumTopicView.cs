using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicView
    {
        public int ForumTopicViewId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ForumTopicId { get; set; }
        public DateTime DayDate { get; set; }
        public int ViewCount { get; set; }

        public ForumTopic ForumTopic { get; set; }
    }
}
