using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ConversationMessageState
    {
        public string UserId { get; set; }
        public int ConversationMessageId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool Read { get; set; }
        public DateTime? ReadOn { get; set; }

        public ConversationMessage ConversationMessage { get; set; }
        public AspNetUsers User { get; set; }
    }
}
