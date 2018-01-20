using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicClubMapper
    {
        public int ForumTopicId { get; set; }
        public int ClubId { get; set; }

        public ForumTopic ForumTopic { get; set; }
    }
}
