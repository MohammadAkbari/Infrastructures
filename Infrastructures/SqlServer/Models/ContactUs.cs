using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ContactUs
    {
        public int Id { get; set; }
        public int ContactSubjectType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Email { get; set; }
        public string IpAddress { get; set; }
        public bool IsRead { get; set; }
        public string Mobile { get; set; }
        public string NameFamily { get; set; }
        public DateTime? ReadOn { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string Body { get; set; }
    }
}
