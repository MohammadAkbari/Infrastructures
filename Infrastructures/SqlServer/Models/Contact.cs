using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Contact
    {
        public Contact()
        {
            ContactRequest = new HashSet<ContactRequest>();
        }

        public int ContactId { get; set; }
        public string AddresseeId { get; set; }
        public int ContactState { get; set; }
        public DateTime CreatedOn { get; set; }
        public string RequesterId { get; set; }

        public AspNetUsers Addressee { get; set; }
        public AspNetUsers Requester { get; set; }
        public ICollection<ContactRequest> ContactRequest { get; set; }
    }
}
