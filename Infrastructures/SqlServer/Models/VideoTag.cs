using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoTag
    {
        public VideoTag()
        {
            VideoVideoTag = new HashSet<VideoVideoTag>();
        }

        public int VideoTagId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<VideoVideoTag> VideoVideoTag { get; set; }
    }
}
