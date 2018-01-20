using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ForumCategory
    {
        public ForumCategory()
        {
            Forum = new HashSet<Forum>();
        }

        public int ForumCategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool Inactive { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ForumCategoryMapper ForumCategoryMapper { get; set; }
        public ICollection<Forum> Forum { get; set; }
    }
}
