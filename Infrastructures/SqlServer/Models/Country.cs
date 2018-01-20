using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Country
    {
        public Country()
        {
            Province = new HashSet<Province>();
        }

        public int CountryId { get; set; }
        public string Alias { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<Province> Province { get; set; }
    }
}
