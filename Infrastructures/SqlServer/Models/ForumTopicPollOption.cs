using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicPollOption
    {
        public ForumTopicPollOption()
        {
            ForumTopicPollVote = new HashSet<ForumTopicPollVote>();
        }

        public int ForumTopicPollOptionId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int ForumTopicPollId { get; set; }
        public string OptionText { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ForumTopicPoll ForumTopicPoll { get; set; }
        public ICollection<ForumTopicPollVote> ForumTopicPollVote { get; set; }
    }
}
