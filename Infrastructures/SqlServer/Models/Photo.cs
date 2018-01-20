using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Photo
    {
        public Photo()
        {
            PhotoComment = new HashSet<PhotoComment>();
            PhotoCompetitionPhoto = new HashSet<PhotoCompetitionPhoto>();
            PhotoFavorite = new HashSet<PhotoFavorite>();
            PhotoJuncCategory = new HashSet<PhotoJuncCategory>();
            PhotoJuncTag = new HashSet<PhotoJuncTag>();
            PhotoLog = new HashSet<PhotoLog>();
            PhotoReport = new HashSet<PhotoReport>();
            PhotoView = new HashSet<PhotoView>();
            PhotoVote = new HashSet<PhotoVote>();
        }

        public int PhotoId { get; set; }
        public bool AllowComment { get; set; }
        public int CommentCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public int MediaExtension { get; set; }
        public string Path { get; set; }
        public int? PhotoGalleryId { get; set; }
        public int PhotoStatus { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public int ViewCount { get; set; }

        public PhotoGallery PhotoGallery { get; set; }
        public AspNetUsers User { get; set; }
        public PhotoMapper PhotoMapper { get; set; }
        public ICollection<PhotoComment> PhotoComment { get; set; }
        public ICollection<PhotoCompetitionPhoto> PhotoCompetitionPhoto { get; set; }
        public ICollection<PhotoFavorite> PhotoFavorite { get; set; }
        public ICollection<PhotoJuncCategory> PhotoJuncCategory { get; set; }
        public ICollection<PhotoJuncTag> PhotoJuncTag { get; set; }
        public ICollection<PhotoLog> PhotoLog { get; set; }
        public ICollection<PhotoReport> PhotoReport { get; set; }
        public ICollection<PhotoView> PhotoView { get; set; }
        public ICollection<PhotoVote> PhotoVote { get; set; }
    }
}
