using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoCommentMapper
    {
        public int PhotoCommentId { get; set; }
        public long OldPhotoCommentId { get; set; }

        public PhotoComment PhotoComment { get; set; }
    }
}
