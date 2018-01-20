using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoMapper
    {
        public int PhotoId { get; set; }
        public long OldPhotoId { get; set; }

        public Photo Photo { get; set; }
    }
}
