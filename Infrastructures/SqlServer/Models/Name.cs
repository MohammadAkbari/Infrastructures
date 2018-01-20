using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Name
    {
        public Name()
        {
            NameOriginJuncName = new HashSet<NameOriginJuncName>();
            NameView = new HashSet<NameView>();
            NameVote = new HashSet<NameVote>();
        }

        public int NameId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public int NameFirstLetter { get; set; }
        public int NameGenderType { get; set; }
        public string Normalized { get; set; }
        public string Pronounce { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int ViewCount { get; set; }

        public NameMapper NameMapper { get; set; }
        public ICollection<NameOriginJuncName> NameOriginJuncName { get; set; }
        public ICollection<NameView> NameView { get; set; }
        public ICollection<NameVote> NameVote { get; set; }
    }
}
