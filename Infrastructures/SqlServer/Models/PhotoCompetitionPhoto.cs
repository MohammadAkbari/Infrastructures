using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoCompetitionPhoto
    {
        public PhotoCompetitionPhoto()
        {
            PhotoCompetitionScore = new HashSet<PhotoCompetitionScore>();
        }

        public int PhotoCompetitionPhotoId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int PhotoCompetitionId { get; set; }
        public int PhotoId { get; set; }
        public int ScoreCount { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }

        public Photo Photo { get; set; }
        public PhotoCompetition PhotoCompetition { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<PhotoCompetitionScore> PhotoCompetitionScore { get; set; }
    }
}
