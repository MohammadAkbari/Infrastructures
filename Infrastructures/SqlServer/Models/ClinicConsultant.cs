using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicConsultant
    {
        public ClinicConsultant()
        {
            ClinicCategoryConsultant = new HashSet<ClinicCategoryConsultant>();
            ClinicConsultantAnswer = new HashSet<ClinicConsultantAnswer>();
            ClinicQuestion = new HashSet<ClinicQuestion>();
        }

        public string ClinicConsultantId { get; set; }
        public bool Active { get; set; }
        public int AnswerCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Education { get; set; }
        public string Experiences { get; set; }
        public string Expertise { get; set; }
        public string Prename { get; set; }
        public string Resume { get; set; }
        public string Skills { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public AspNetUsers ClinicConsultantNavigation { get; set; }
        public ClinicConsultantMapper ClinicConsultantMapper { get; set; }
        public ICollection<ClinicCategoryConsultant> ClinicCategoryConsultant { get; set; }
        public ICollection<ClinicConsultantAnswer> ClinicConsultantAnswer { get; set; }
        public ICollection<ClinicQuestion> ClinicQuestion { get; set; }
    }
}
