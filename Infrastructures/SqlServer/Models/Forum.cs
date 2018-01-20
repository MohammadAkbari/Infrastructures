using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Forum
    {
        public Forum()
        {
            ForumModerator = new HashSet<ForumModerator>();
            ForumTopic = new HashSet<ForumTopic>();
        }

        public int ForumId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public int ForumCategoryId { get; set; }
        public bool Inactive { get; set; }
        public int? LastForumTopicId { get; set; }
        public DateTime? LastPostCreatedOn { get; set; }
        public string LastPostUserName { get; set; }
        public string Moderators { get; set; }
        public string Name { get; set; }
        public int PostCount { get; set; }
        public bool Sticky { get; set; }
        public int TopicCount { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool OnlyModeratorPermissionToAddTopic { get; set; }

        public ForumCategory ForumCategory { get; set; }
        public ForumClubGroupsMapper ForumClubGroupsMapper { get; set; }
        public ForumMapper ForumMapper { get; set; }
        public ICollection<ForumModerator> ForumModerator { get; set; }
        public ICollection<ForumTopic> ForumTopic { get; set; }
    }
}
