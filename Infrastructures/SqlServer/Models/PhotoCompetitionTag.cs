using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoCompetitionTag
    {
        public int PhotoCompetitionId { get; set; }
        public int PhotoTagId { get; set; }

        public PhotoCompetition PhotoCompetition { get; set; }
        public PhotoTag PhotoTag { get; set; }
    }
}
