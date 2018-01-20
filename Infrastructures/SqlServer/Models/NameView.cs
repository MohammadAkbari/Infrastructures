using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class NameView
    {
        public int NameViewId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int NameId { get; set; }
        public DateTime DayDate { get; set; }
        public int ViewCount { get; set; }

        public Name Name { get; set; }
    }
}
