using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogCategoryMapper
    {
        public int BlogCategoryMapperId { get; set; }
        public int BlogCategoryId { get; set; }

        public BlogCategory BlogCategory { get; set; }
    }
}
