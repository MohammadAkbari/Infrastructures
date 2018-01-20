using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicDailyViewCount
    {
        public int ForumTopicId { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public ForumTopic ForumTopic { get; set; }
    }
}
