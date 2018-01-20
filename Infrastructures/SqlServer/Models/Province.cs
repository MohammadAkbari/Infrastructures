using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Province
    {
        public Province()
        {
            City = new HashSet<City>();
            UserProfile = new HashSet<UserProfile>();
        }

        public int ProvinceId { get; set; }
        public int CountryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public Country Country { get; set; }
        public ICollection<City> City { get; set; }
        public ICollection<UserProfile> UserProfile { get; set; }
    }
}
