using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicConsultantMapper
    {
        public string ClinicConsultantId { get; set; }
        public int OldConsultantId { get; set; }

        public ClinicConsultant ClinicConsultant { get; set; }
    }
}
