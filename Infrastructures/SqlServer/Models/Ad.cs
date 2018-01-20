using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Ad
    {
        public Ad()
        {
            AdClick = new HashSet<AdClick>();
            AdHistory = new HashSet<AdHistory>();
            AdView = new HashSet<AdView>();
        }

        public int AdId { get; set; }
        public int AdFileType { get; set; }
        public int AdType { get; set; }
        public int AdZoneId { get; set; }
        public int ClickCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime EndedOn { get; set; }
        public int Height { get; set; }
        public string HtmlContent { get; set; }
        public string Link { get; set; }
        public int? MediaExtension { get; set; }
        public string Path { get; set; }
        public int? Percent { get; set; }
        public DateTime StartedOn { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int ViewCount { get; set; }
        public int Width { get; set; }

        public AdZone AdZone { get; set; }
        public ICollection<AdClick> AdClick { get; set; }
        public ICollection<AdHistory> AdHistory { get; set; }
        public ICollection<AdView> AdView { get; set; }
    }
}
