using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Announcement
    {
        public int AnnouncementId { get; set; }
        public int AnnouncementType { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public DateTime FinishedOn { get; set; }
        public string ImagePath { get; set; }
        public bool Published { get; set; }
        public DateTime StartedOn { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Url { get; set; }
    }
}
