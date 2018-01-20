using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class UserEmbryo
    {
        public int UserEmbryoId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public bool DisplayPregnancyTicker { get; set; }
        public int? EmbryoCount { get; set; }
        public int GenderType { get; set; }
        public string Name { get; set; }
        public int? PregnancyTickerId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public string TickerTitle { get; set; }

        public PregnancyTicker PregnancyTicker { get; set; }
        public UserProfile User { get; set; }
    }
}
