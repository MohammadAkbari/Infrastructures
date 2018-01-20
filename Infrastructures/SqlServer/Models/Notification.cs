using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Notification
    {
        public long NotificationId { get; set; }
        public int ContentId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string DestinationUserId { get; set; }
        public int NotificationType { get; set; }
        public int NotifierType { get; set; }
        public bool Seen { get; set; }
        public string SourceUserId { get; set; }
        public bool Read { get; set; }
        public DateTime? ReadOn { get; set; }
        public DateTime? SeenOn { get; set; }

        public AspNetUsers DestinationUser { get; set; }
        public AspNetUsers SourceUser { get; set; }
    }
}
