using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicConsultantAnswerUseful
    {
        public int ClinicConsultantAnswerId { get; set; }
        public string UserId { get; set; }

        public ClinicConsultantAnswer ClinicConsultantAnswer { get; set; }
        public AspNetUsers User { get; set; }
    }
}
