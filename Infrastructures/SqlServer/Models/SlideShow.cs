using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class SlideShow
    {
        public int SlideShowId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public string Link { get; set; }
        public int MediaExtension { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Description { get; set; }
    }
}
