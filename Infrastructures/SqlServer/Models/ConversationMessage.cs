using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ConversationMessage
    {
        public ConversationMessage()
        {
            ConversationMessageState = new HashSet<ConversationMessageState>();
        }

        public int ConversationMessageId { get; set; }
        public int ConversationId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public string Message { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }

        public Conversation Conversation { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<ConversationMessageState> ConversationMessageState { get; set; }
    }
}
