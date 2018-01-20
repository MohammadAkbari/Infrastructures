using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class City
    {
        public City()
        {
            UserProfile = new HashSet<UserProfile>();
        }

        public int CityId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int ProvinceId { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public Province Province { get; set; }
        public ICollection<UserProfile> UserProfile { get; set; }
    }
}
