using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PregnancyTicker
    {
        public PregnancyTicker()
        {
            UserEmbryo = new HashSet<UserEmbryo>();
        }

        public int PregnancyTickerId { get; set; }
        public string Color { get; set; }
        public bool Deleted { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public ICollection<UserEmbryo> UserEmbryo { get; set; }
    }
}
