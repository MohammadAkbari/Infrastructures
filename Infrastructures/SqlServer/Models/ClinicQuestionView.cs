using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicQuestionView
    {
        public int ClinicQuestionViewId { get; set; }
        public int ClinicQuestionId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DayDate { get; set; }
        public int ViewCount { get; set; }

        public ClinicQuestion ClinicQuestion { get; set; }
    }
}
