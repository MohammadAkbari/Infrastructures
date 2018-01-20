using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Permission
    {
        public int PermissionId { get; set; }
        public int ApplicationRoleId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string PermissionName { get; set; }

        public ApplicationRole ApplicationRole { get; set; }
    }
}
