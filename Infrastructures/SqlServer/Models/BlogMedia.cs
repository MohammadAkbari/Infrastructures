using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogMedia
    {
        public BlogMedia()
        {
            BlogMediaTag = new HashSet<BlogMediaTag>();
        }

        public int BlogMediaId { get; set; }
        public string Concessionaire { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int MediaExtension { get; set; }
        public int MediaType { get; set; }
        public string Path { get; set; }
        public string Photographer { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool WatermarkNeeded { get; set; }

        public ICollection<BlogMediaTag> BlogMediaTag { get; set; }
    }
}
