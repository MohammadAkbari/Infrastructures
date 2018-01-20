using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class NameMapper
    {
        public int VideoCategoryId { get; set; }
        public int OldNameId { get; set; }

        public Name VideoCategory { get; set; }
    }
}
