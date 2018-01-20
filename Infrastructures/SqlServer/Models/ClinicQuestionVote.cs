using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicQuestionVote
    {
        public int ClinicQuestionId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }

        public ClinicQuestion ClinicQuestion { get; set; }
        public AspNetUsers User { get; set; }
    }
}
