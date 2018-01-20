using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogPostCategory
    {
        public int BlogPostId { get; set; }
        public int BlogCategoryId { get; set; }

        public BlogCategory BlogCategory { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
