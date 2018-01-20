using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicCategoryMapper
    {
        public int ClinicCategoryId { get; set; }
        public int OldCategoryId { get; set; }

        public ClinicCategory ClinicCategory { get; set; }
    }
}
