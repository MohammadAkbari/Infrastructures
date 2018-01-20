using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoReport
    {
        public int PhotoReportId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public int PhotoId { get; set; }
        public int PhotoReportType { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }

        public Photo Photo { get; set; }
        public AspNetUsers User { get; set; }
    }
}
