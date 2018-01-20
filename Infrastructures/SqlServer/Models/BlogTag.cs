using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogTag
    {
        public BlogTag()
        {
            BlogMediaTag = new HashSet<BlogMediaTag>();
            BlogPostTag = new HashSet<BlogPostTag>();
        }

        public int BlogTagId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<BlogMediaTag> BlogMediaTag { get; set; }
        public ICollection<BlogPostTag> BlogPostTag { get; set; }
    }
}
