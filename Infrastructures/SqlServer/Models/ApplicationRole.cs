using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ApplicationRole
    {
        public ApplicationRole()
        {
            ApplicationRoleUser = new HashSet<ApplicationRoleUser>();
            Permission = new HashSet<Permission>();
        }

        public int ApplicationRoleId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<ApplicationRoleUser> ApplicationRoleUser { get; set; }
        public ICollection<Permission> Permission { get; set; }
    }
}
