using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoCompetitionScore
    {
        public int PhotoCompetitionScoreId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int PhotoCompetitionPhotoId { get; set; }
        public int Score { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }

        public PhotoCompetitionPhoto PhotoCompetitionPhoto { get; set; }
        public AspNetUsers User { get; set; }
    }
}
