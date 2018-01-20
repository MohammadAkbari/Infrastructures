using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class UserMapper
    {
        public string UserId { get; set; }
        public int OldUserId { get; set; }

        public AspNetUsers User { get; set; }
    }
}
