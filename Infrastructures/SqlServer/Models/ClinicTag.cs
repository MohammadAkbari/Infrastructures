using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicTag
    {
        public ClinicTag()
        {
            ClinicQuestionTag = new HashSet<ClinicQuestionTag>();
        }

        public int ClinicTagId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<ClinicQuestionTag> ClinicQuestionTag { get; set; }
    }
}
