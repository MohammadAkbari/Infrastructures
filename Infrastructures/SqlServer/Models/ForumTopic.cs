using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumTopic
    {
        public ForumTopic()
        {
            ForumPost = new HashSet<ForumPost>();
            ForumTopicDailyViewCount = new HashSet<ForumTopicDailyViewCount>();
            ForumTopicFavorite = new HashSet<ForumTopicFavorite>();
            ForumTopicLog = new HashSet<ForumTopicLog>();
            ForumTopicManager = new HashSet<ForumTopicManager>();
            ForumTopicMember = new HashSet<ForumTopicMember>();
            ForumTopicReport = new HashSet<ForumTopicReport>();
            ForumTopicView = new HashSet<ForumTopicView>();
            ForumTopicVote = new HashSet<ForumTopicVote>();
        }

        public int ForumTopicId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int ForumId { get; set; }
        public int ForumTopicState { get; set; }
        public bool HasForumTopicPoll { get; set; }
        public DateTime? LastRepliedOn { get; set; }
        public bool Private { get; set; }
        public int ReplyCount { get; set; }
        public int ReportCount { get; set; }
        public bool ShowInAllForum { get; set; }
        public bool Sticky { get; set; }
        public string Subject { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public int ViewCount { get; set; }
        public int OpenCloseState { get; set; }
        public int LikeCount { get; set; }
        public int? LastReplyId { get; set; }

        public Forum Forum { get; set; }
        public AspNetUsers User { get; set; }
        public ForumTopicClubMapper ForumTopicClubMapper { get; set; }
        public ForumTopicMapper ForumTopicMapper { get; set; }
        public ForumTopicPoll ForumTopicPoll { get; set; }
        public ICollection<ForumPost> ForumPost { get; set; }
        public ICollection<ForumTopicDailyViewCount> ForumTopicDailyViewCount { get; set; }
        public ICollection<ForumTopicFavorite> ForumTopicFavorite { get; set; }
        public ICollection<ForumTopicLog> ForumTopicLog { get; set; }
        public ICollection<ForumTopicManager> ForumTopicManager { get; set; }
        public ICollection<ForumTopicMember> ForumTopicMember { get; set; }
        public ICollection<ForumTopicReport> ForumTopicReport { get; set; }
        public ICollection<ForumTopicView> ForumTopicView { get; set; }
        public ICollection<ForumTopicVote> ForumTopicVote { get; set; }
    }
}
