using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoCategory
    {
        public VideoCategory()
        {
            InverseParentCategory = new HashSet<VideoCategory>();
            VideoVideoCategory = new HashSet<VideoVideoCategory>();
        }

        public int VideoCategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string LastThumbnailPath { get; set; }
        public int? LastVideoId { get; set; }

        public VideoCategory ParentCategory { get; set; }
        public VideoCategoryMapper VideoCategoryMapper { get; set; }
        public ICollection<VideoCategory> InverseParentCategory { get; set; }
        public ICollection<VideoVideoCategory> VideoVideoCategory { get; set; }
    }
}
