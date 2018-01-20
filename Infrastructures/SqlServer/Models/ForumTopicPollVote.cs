using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicPollVote
    {
        public string UserId { get; set; }
        public int ForumTopicPollOptionId { get; set; }
        public DateTime CreatedOn { get; set; }

        public ForumTopicPollOption ForumTopicPollOption { get; set; }
        public AspNetUsers User { get; set; }
    }
}
