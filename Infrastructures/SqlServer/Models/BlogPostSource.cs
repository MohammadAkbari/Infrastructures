using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogPostSource
    {
        public int BlogPostSourceId { get; set; }
        public int BlogPostId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public BlogPost BlogPost { get; set; }
    }
}
