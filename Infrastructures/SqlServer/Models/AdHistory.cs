using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdHistory
    {
        public int AdHistoryId { get; set; }
        public int AdFileType { get; set; }
        public int AdId { get; set; }
        public int AdType { get; set; }
        public int AdZoneId { get; set; }
        public DateTime CreatedOn { get; set; }
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
        public int Width { get; set; }
        public int AdPage { get; set; }
        public int AdPageId { get; set; }
        public string AdPageTitle { get; set; }
        public int AdZone { get; set; }
        public string AdZoneTitle { get; set; }
        public int ClickCount { get; set; }
        public int ViewCount { get; set; }

        public Ad Ad { get; set; }
    }
}
