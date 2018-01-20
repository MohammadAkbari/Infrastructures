using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDb.Models
{
    public class ForumTopic
    {
        [BsonId]
        public int Id { get; set; }
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
    }
}
