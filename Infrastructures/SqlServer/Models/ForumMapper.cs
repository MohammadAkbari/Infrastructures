using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumMapper
    {
        public int ForumId { get; set; }
        public int OldForumId { get; set; }

        public Forum Forum { get; set; }
    }
}
