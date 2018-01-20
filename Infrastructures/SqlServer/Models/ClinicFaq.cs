using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicFaq
    {
        public ClinicFaq()
        {
            ClinicCategoryFaq = new HashSet<ClinicCategoryFaq>();
        }

        public int ClinicFaqId { get; set; }
        public string Answer { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int DisLike { get; set; }
        public string Image { get; set; }
        public int Like { get; set; }
        public bool Published { get; set; }
        public string Question { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int VisitedCount { get; set; }

        public ICollection<ClinicCategoryFaq> ClinicCategoryFaq { get; set; }
    }
}
