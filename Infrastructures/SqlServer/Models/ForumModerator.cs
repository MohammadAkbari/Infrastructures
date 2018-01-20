using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumModerator
    {
        public int ForumId { get; set; }
        public string ModeratorId { get; set; }

        public Forum Forum { get; set; }
        public Moderator Moderator { get; set; }
    }
}
