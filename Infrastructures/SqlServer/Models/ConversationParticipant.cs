using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ConversationParticipant
    {
        public string UserId { get; set; }
        public int ConversationId { get; set; }
        public bool Deleted { get; set; }
        public bool Posted { get; set; }
        public bool Read { get; set; }
        public bool Received { get; set; }

        public Conversation Conversation { get; set; }
        public AspNetUsers User { get; set; }
    }
}
