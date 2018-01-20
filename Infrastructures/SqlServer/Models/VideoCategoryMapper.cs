using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoCategoryMapper
    {
        public int VideoCategoryId { get; set; }
        public int OldVideoCategoryId { get; set; }

        public VideoCategory VideoCategory { get; set; }
    }
}
