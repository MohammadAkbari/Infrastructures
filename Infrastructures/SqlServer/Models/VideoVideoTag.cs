using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoVideoTag
    {
        public int VideoId { get; set; }
        public int VideoTagId { get; set; }

        public Video Video { get; set; }
        public VideoTag VideoTag { get; set; }
    }
}
