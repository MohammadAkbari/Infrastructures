using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class UserPicture
    {
        public int UserPictureId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsSelected { get; set; }
        public int MediaExtension { get; set; }
        public string Path { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }

        public AspNetUsers User { get; set; }
    }
}
