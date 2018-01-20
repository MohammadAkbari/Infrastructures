using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogPostView
    {
        public int BlogPostViewId { get; set; }
        public int BlogPostId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DayDate { get; set; }
        public int ViewCount { get; set; }

        public BlogPost BlogPost { get; set; }
    }
}
