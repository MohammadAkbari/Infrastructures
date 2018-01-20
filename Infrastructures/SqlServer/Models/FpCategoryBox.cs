using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class FpCategoryBox
    {
        public FpCategoryBox()
        {
            BlogCategoryJuncFpCategoryBox = new HashSet<BlogCategoryJuncFpCategoryBox>();
        }

        public int FpCategoryBoxId { get; set; }
        public int CoverMediaExtension { get; set; }
        public string CoverPath { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public int FpCategoryBoxColor { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<BlogCategoryJuncFpCategoryBox> BlogCategoryJuncFpCategoryBox { get; set; }
    }
}
