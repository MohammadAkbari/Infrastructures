using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicConsultantAnswer
    {
        public ClinicConsultantAnswer()
        {
            ClinicConsultantAnswerUseful = new HashSet<ClinicConsultantAnswerUseful>();
        }

        public int ClinicConsultantAnswerId { get; set; }
        public string Answer { get; set; }
        public string AnswerUserId { get; set; }
        public string ClinicConsultantId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int UsefulCount { get; set; }

        public ClinicConsultant ClinicConsultant { get; set; }
        public ClinicQuestion ClinicConsultantAnswerNavigation { get; set; }
        public ICollection<ClinicConsultantAnswerUseful> ClinicConsultantAnswerUseful { get; set; }
    }
}
