using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicQuestionMapper
    {
        public int ClinicQuestionId { get; set; }
        public int OldQuestionId { get; set; }

        public ClinicQuestion ClinicQuestion { get; set; }
    }
}
