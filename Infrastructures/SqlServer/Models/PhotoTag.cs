using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoTag
    {
        public PhotoTag()
        {
            PhotoCompetitionTag = new HashSet<PhotoCompetitionTag>();
            PhotoJuncTag = new HashSet<PhotoJuncTag>();
        }

        public int PhotoTagId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string LastImagePath { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? LastPhotoId { get; set; }

        public PhotoTagMapper PhotoTagMapper { get; set; }
        public ICollection<PhotoCompetitionTag> PhotoCompetitionTag { get; set; }
        public ICollection<PhotoJuncTag> PhotoJuncTag { get; set; }
    }
}
