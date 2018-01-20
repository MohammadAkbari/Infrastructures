using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class NameOriginJuncName
    {
        public int NameId { get; set; }
        public int NameOriginId { get; set; }

        public Name Name { get; set; }
        public NameOrigin NameOrigin { get; set; }
    }
}
