using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            UserChild = new HashSet<UserChild>();
            UserEmbryo = new HashSet<UserEmbryo>();
        }

        public string UserId { get; set; }
        public string Address { get; set; }
        public string BirthCertificateId { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? CityId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string DegreeOfEducation { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public bool EmailFriendRequestNotification { get; set; }
        public bool EmailReplyLikeNotification { get; set; }
        public string Family { get; set; }
        public int? GenderType { get; set; }
        public bool IsPublic { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string NameFamily { get; set; }
        public string NationalCode { get; set; }
        public string Occupation { get; set; }
        public string PostalCode { get; set; }
        public int? ProvinceId { get; set; }
        public string Specialty { get; set; }
        public bool SubscribeToNewsletter { get; set; }
        public string Telephone { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public City City { get; set; }
        public Province Province { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<UserChild> UserChild { get; set; }
        public ICollection<UserEmbryo> UserEmbryo { get; set; }
    }
}
