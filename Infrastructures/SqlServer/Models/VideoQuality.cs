using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoQuality
    {
        public int VideoQualityId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int MediaExtension { get; set; }
        public int? Quality { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int VideoId { get; set; }
        public string VideoPath { get; set; }

        public Video Video { get; set; }
    }
}
