using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ContactRequest
    {
        public int ContactRequestId { get; set; }
        public int ContactId { get; set; }
        public int ContactState { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }

        public Contact Contact { get; set; }
        public AspNetUsers User { get; set; }
    }
}
