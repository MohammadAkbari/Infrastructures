using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopicPoll
    {
        public ForumTopicPoll()
        {
            ForumTopicPollLog = new HashSet<ForumTopicPollLog>();
            ForumTopicPollOption = new HashSet<ForumTopicPollOption>();
        }

        public int ForumTopicPollId { get; set; }
        public bool Closed { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public DateTime? FinishedOn { get; set; }
        public int ForumTopicPollState { get; set; }
        public string Question { get; set; }
        public DateTime StartedOn { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ForumTopic ForumTopicPollNavigation { get; set; }
        public ICollection<ForumTopicPollLog> ForumTopicPollLog { get; set; }
        public ICollection<ForumTopicPollOption> ForumTopicPollOption { get; set; }
    }
}
