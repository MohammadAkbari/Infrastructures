using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoTagMapper
    {
        public int PhotoTagId { get; set; }
        public int OldPhotoTagId { get; set; }

        public PhotoTag PhotoTag { get; set; }
    }
}
