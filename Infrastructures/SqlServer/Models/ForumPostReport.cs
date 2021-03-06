﻿using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumPostReport
    {
        public int ForumPostReportId { get; set; }
        public bool Checked { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int ForumPostId { get; set; }
        public string Message { get; set; }
        public int ReportType { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public DateTime? ZappedOn { get; set; }
        public string ZappedUserId { get; set; }

        public ForumPost ForumPost { get; set; }
        public AspNetUsers User { get; set; }
        public AspNetUsers ZappedUser { get; set; }
    }
}
