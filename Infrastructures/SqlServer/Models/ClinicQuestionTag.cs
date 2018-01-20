using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicQuestionTag
    {
        public int ClinicQuestionId { get; set; }
        public int ClinicTagId { get; set; }

        public ClinicQuestion ClinicQuestion { get; set; }
        public ClinicTag ClinicTag { get; set; }
    }
}
