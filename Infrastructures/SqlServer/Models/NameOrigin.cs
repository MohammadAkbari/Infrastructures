using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class NameOrigin
    {
        public NameOrigin()
        {
            NameOriginJuncName = new HashSet<NameOriginJuncName>();
        }

        public int NameOriginId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<NameOriginJuncName> NameOriginJuncName { get; set; }
    }
}
