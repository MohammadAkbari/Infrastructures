using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Moderator
    {
        public Moderator()
        {
            ForumModerator = new HashSet<ForumModerator>();
        }

        public string ModeratorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Inactive { get; set; }
        public int ModeratorType { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserName { get; set; }

        public AspNetUsers ModeratorNavigation { get; set; }
        public ICollection<ForumModerator> ForumModerator { get; set; }
    }
}
