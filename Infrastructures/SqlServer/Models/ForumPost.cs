using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumPost
    {
        public ForumPost()
        {
            ForumPostFavorite = new HashSet<ForumPostFavorite>();
            ForumPostLog = new HashSet<ForumPostLog>();
            ForumPostReport = new HashSet<ForumPostReport>();
            ForumPostVote = new HashSet<ForumPostVote>();
            InverseReplyForumPost = new HashSet<ForumPost>();
        }

        public int ForumPostId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int DislikeCount { get; set; }
        public int ForumPostState { get; set; }
        public int ForumTopicId { get; set; }
        public bool IncludeFile { get; set; }
        public int LikeCount { get; set; }
        public string Message { get; set; }
        public bool ModeratorPost { get; set; }
        public int ReplyCount { get; set; }
        public int? ReplyForumPostId { get; set; }
        public int ReportCount { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public bool IsTopicPost { get; set; }

        public ForumTopic ForumTopic { get; set; }
        public ForumPost ReplyForumPost { get; set; }
        public AspNetUsers User { get; set; }
        public ForumPostClubPostMapper ForumPostClubPostMapper { get; set; }
        public ForumPostEverybodyCanTalkAboutMapper ForumPostEverybodyCanTalkAboutMapper { get; set; }
        public ForumPostMapper ForumPostMapper { get; set; }
        public ICollection<ForumPostFavorite> ForumPostFavorite { get; set; }
        public ICollection<ForumPostLog> ForumPostLog { get; set; }
        public ICollection<ForumPostReport> ForumPostReport { get; set; }
        public ICollection<ForumPostVote> ForumPostVote { get; set; }
        public ICollection<ForumPost> InverseReplyForumPost { get; set; }
    }
}
