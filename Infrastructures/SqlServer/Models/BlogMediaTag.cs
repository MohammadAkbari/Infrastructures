using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogMediaTag
    {
        public int BlogMediaId { get; set; }
        public int BlogTagId { get; set; }

        public BlogMedia BlogMedia { get; set; }
        public BlogTag BlogTag { get; set; }
    }
}
