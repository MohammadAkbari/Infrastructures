using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class NewsMapper
    {
        public int NewsId { get; set; }
        public int EntityId { get; set; }
        public int NewsType { get; set; }
    }
}
