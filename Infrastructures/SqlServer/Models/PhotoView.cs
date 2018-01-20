﻿using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoView
    {
        public int PhotoViewId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int PhotoId { get; set; }
        public DateTime DayDate { get; set; }
        public int ViewCount { get; set; }

        public Photo Photo { get; set; }
    }
}
