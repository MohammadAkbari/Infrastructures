using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogCategory
    {
        public BlogCategory()
        {
            BlogCategoryJuncFpCategoryBox = new HashSet<BlogCategoryJuncFpCategoryBox>();
            BlogCategoryMapper = new HashSet<BlogCategoryMapper>();
            BlogPostCategory = new HashSet<BlogPostCategory>();
            InverseParentCategory = new HashSet<BlogCategory>();
        }

        public int BlogCategoryId { get; set; }
        public int CoverMediaExtension { get; set; }
        public string CoverPath { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public BlogCategory ParentCategory { get; set; }
        public ICollection<BlogCategoryJuncFpCategoryBox> BlogCategoryJuncFpCategoryBox { get; set; }
        public ICollection<BlogCategoryMapper> BlogCategoryMapper { get; set; }
        public ICollection<BlogPostCategory> BlogPostCategory { get; set; }
        public ICollection<BlogCategory> InverseParentCategory { get; set; }
    }
}
