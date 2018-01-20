using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumClubGroupsMapper
    {
        public int ForumId { get; set; }
        public int ClubGroupId { get; set; }

        public Forum Forum { get; set; }
    }
}
