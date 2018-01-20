using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class UserChild
    {
        public int UserChildId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int? GenderType { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }

        public UserProfile User { get; set; }
    }
}
