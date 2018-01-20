using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class PhotoGallery
    {
        public PhotoGallery()
        {
            Photo = new HashSet<Photo>();
        }

        public int PhotoGalleryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int PhotoGalleryType { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }

        public AspNetUsers User { get; set; }
        public ICollection<Photo> Photo { get; set; }
    }
}
