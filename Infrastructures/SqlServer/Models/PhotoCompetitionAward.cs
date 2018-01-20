using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoCompetitionAward
    {
        public int PhotoCompetitionAwardId { get; set; }
        public string ImagePath { get; set; }
        public int PhotoCompetitionId { get; set; }
        public string Title { get; set; }

        public PhotoCompetition PhotoCompetition { get; set; }
    }
}
