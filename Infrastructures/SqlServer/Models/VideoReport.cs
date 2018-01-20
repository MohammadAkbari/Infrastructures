using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoReport
    {
        public int VideoReportId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public int VideoId { get; set; }
        public int VideoReportType { get; set; }

        public AspNetUsers User { get; set; }
        public Video Video { get; set; }
    }
}
