using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ConversationMapper
    {
        public int ConversationId { get; set; }
        public int OldId { get; set; }

        public Conversation Conversation { get; set; }
    }
}
