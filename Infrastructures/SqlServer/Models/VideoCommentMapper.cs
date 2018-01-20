using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoCommentMapper
    {
        public int VideoCommentId { get; set; }
        public long OldVideoCommentId { get; set; }

        public VideoComment VideoComment { get; set; }
    }
}
