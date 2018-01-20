using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Timeline
    {
        public Timeline()
        {
            TimelineComment = new HashSet<TimelineComment>();
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public int CommentCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int DigitTitle { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public int LikeCount { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public bool Published { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public int ViewCount { get; set; }
        public int? TimelineMonth { get; set; }
        public int TimelineType { get; set; }
        public int? TimelineWeek { get; set; }
        public int? TimelineYear { get; set; }

        public AspNetUsers User { get; set; }
        public ICollection<TimelineComment> TimelineComment { get; set; }
    }
}
