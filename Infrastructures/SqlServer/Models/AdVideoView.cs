using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdVideoView
    {
        public int AdVideoViewId { get; set; }
        public int AdVideoId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DayDate { get; set; }
        public int ViewCount { get; set; }

        public AdVideo AdVideo { get; set; }
    }
}
