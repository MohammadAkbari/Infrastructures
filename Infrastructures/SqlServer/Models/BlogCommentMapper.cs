using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogCommentMapper
    {
        public int BlogCommentId { get; set; }
        public int CommentId { get; set; }

        public BlogComment BlogComment { get; set; }
    }
}
