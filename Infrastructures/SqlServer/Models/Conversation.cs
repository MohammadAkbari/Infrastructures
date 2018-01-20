using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Conversation
    {
        public Conversation()
        {
            ConversationMessage = new HashSet<ConversationMessage>();
            ConversationParticipant = new HashSet<ConversationParticipant>();
        }

        public int ConversationId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public string Subject { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }
        public DateTime? LastMessageSentOn { get; set; }

        public AspNetUsers User { get; set; }
        public ConversationMapper ConversationMapper { get; set; }
        public ICollection<ConversationMessage> ConversationMessage { get; set; }
        public ICollection<ConversationParticipant> ConversationParticipant { get; set; }
    }
}
