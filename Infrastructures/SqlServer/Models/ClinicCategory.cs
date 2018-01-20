using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicCategory
    {
        public ClinicCategory()
        {
            ClinicCategoryConsultant = new HashSet<ClinicCategoryConsultant>();
            ClinicCategoryFaq = new HashSet<ClinicCategoryFaq>();
            ClinicQuestion = new HashSet<ClinicQuestion>();
            InverseParentCategory = new HashSet<ClinicCategory>();
        }

        public int ClinicCategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ClinicCategory ParentCategory { get; set; }
        public ClinicCategoryMapper ClinicCategoryMapper { get; set; }
        public ICollection<ClinicCategoryConsultant> ClinicCategoryConsultant { get; set; }
        public ICollection<ClinicCategoryFaq> ClinicCategoryFaq { get; set; }
        public ICollection<ClinicQuestion> ClinicQuestion { get; set; }
        public ICollection<ClinicCategory> InverseParentCategory { get; set; }
    }
}
