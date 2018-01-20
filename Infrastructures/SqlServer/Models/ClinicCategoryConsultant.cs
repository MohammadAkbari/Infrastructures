using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicCategoryConsultant
    {
        public int ClinicCategoryId { get; set; }
        public string ClinicConsultantId { get; set; }

        public ClinicCategory ClinicCategory { get; set; }
        public ClinicConsultant ClinicConsultant { get; set; }
    }
}
