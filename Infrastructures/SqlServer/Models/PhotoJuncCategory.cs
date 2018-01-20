using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoJuncCategory
    {
        public int PhotoId { get; set; }
        public int PhotoCategoryId { get; set; }

        public Photo Photo { get; set; }
        public PhotoCategory PhotoCategory { get; set; }
    }
}
