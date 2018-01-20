using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoVideoCategory
    {
        public int VideoId { get; set; }
        public int VideoCategoryId { get; set; }

        public Video Video { get; set; }
        public VideoCategory VideoCategory { get; set; }
    }
}
