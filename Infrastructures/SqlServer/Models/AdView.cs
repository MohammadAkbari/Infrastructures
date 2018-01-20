using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdView
    {
        public int AdViewId { get; set; }
        public int AdId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DayDate { get; set; }
        public int ViewCount { get; set; }

        public Ad Ad { get; set; }
    }
}
