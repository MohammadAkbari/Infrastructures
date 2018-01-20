using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class VideoPlay
    {
        public int VideoPlayId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DayDate { get; set; }
        public int VideoId { get; set; }
        public int PlayCount { get; set; }

        public Video Video { get; set; }
    }
}
