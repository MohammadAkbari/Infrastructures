using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ApplicationRoleUser
    {
        public string UserId { get; set; }
        public int ApplicationRoleId { get; set; }

        public ApplicationRole ApplicationRole { get; set; }
        public AspNetUsers User { get; set; }
    }
}
