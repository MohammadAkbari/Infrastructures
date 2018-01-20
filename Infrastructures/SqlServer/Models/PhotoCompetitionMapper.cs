using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoCompetitionMapper
    {
        public int PhotoCompetitionId { get; set; }
        public int OldPhotoCompetitionId { get; set; }

        public PhotoCompetition PhotoCompetition { get; set; }
    }
}
