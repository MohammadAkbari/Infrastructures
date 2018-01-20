using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoCompetition
    {
        public PhotoCompetition()
        {
            PhotoCompetitionAward = new HashSet<PhotoCompetitionAward>();
            PhotoCompetitionPhoto = new HashSet<PhotoCompetitionPhoto>();
            PhotoCompetitionTag = new HashSet<PhotoCompetitionTag>();
        }

        public int PhotoCompetitionId { get; set; }
        public string BannerPath { get; set; }
        public int CompetitionWinnerType { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public DateTime? EndDate { get; set; }
        public string SponsorBannerPath { get; set; }
        public string SponsorLink { get; set; }
        public string SponsorName { get; set; }
        public DateTime? StartDate { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public int WinnerCount { get; set; }
        public bool HasAges { get; set; }

        public AspNetUsers User { get; set; }
        public PhotoCompetitionMapper PhotoCompetitionMapper { get; set; }
        public ICollection<PhotoCompetitionAward> PhotoCompetitionAward { get; set; }
        public ICollection<PhotoCompetitionPhoto> PhotoCompetitionPhoto { get; set; }
        public ICollection<PhotoCompetitionTag> PhotoCompetitionTag { get; set; }
    }
}
