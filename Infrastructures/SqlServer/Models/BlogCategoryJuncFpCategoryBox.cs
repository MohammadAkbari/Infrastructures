using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogCategoryJuncFpCategoryBox
    {
        public int FpCategoryBoxId { get; set; }
        public int BlogCategoryId { get; set; }

        public BlogCategory BlogCategory { get; set; }
        public FpCategoryBox FpCategoryBox { get; set; }
    }
}
