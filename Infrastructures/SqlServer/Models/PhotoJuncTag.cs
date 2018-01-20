using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoJuncTag
    {
        public int PhotoId { get; set; }
        public int PhotoTagId { get; set; }

        public Photo Photo { get; set; }
        public PhotoTag PhotoTag { get; set; }
    }
}
