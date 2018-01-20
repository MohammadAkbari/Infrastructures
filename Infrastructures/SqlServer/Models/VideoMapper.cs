using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoMapper
    {
        public int VideoId { get; set; }
        public long OldVideoId { get; set; }

        public Video Video { get; set; }
    }
}
