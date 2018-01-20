using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicCategoryFaq
    {
        public int ClinicCategoryId { get; set; }
        public int ClinicFaqId { get; set; }

        public ClinicCategory ClinicCategory { get; set; }
        public ClinicFaq ClinicFaq { get; set; }
    }
}
