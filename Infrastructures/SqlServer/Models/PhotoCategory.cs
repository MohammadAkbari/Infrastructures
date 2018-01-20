using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoCategory
    {
        public PhotoCategory()
        {
            InverseParentCategory = new HashSet<PhotoCategory>();
            PhotoJuncCategory = new HashSet<PhotoJuncCategory>();
        }

        public int PhotoCategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool Featured { get; set; }
        public bool IsCompetitionCategory { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public PhotoCategory ParentCategory { get; set; }
        public ICollection<PhotoCategory> InverseParentCategory { get; set; }
        public ICollection<PhotoJuncCategory> PhotoJuncCategory { get; set; }
    }
}
