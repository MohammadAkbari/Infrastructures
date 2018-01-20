using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class Video
    {
        public Video()
        {
            VideoComment = new HashSet<VideoComment>();
            VideoFavorite = new HashSet<VideoFavorite>();
            VideoLog = new HashSet<VideoLog>();
            VideoPlay = new HashSet<VideoPlay>();
            VideoQuality = new HashSet<VideoQuality>();
            VideoReport = new HashSet<VideoReport>();
            VideoVideoCategory = new HashSet<VideoVideoCategory>();
            VideoVideoTag = new HashSet<VideoVideoTag>();
            VideoView = new HashSet<VideoView>();
            VideoVote = new HashSet<VideoVote>();
        }

        public int VideoId { get; set; }
        public bool AllowComment { get; set; }
        public bool AllowDownload { get; set; }
        public int CommentCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public double LengthInSeconds { get; set; }
        public int LikeCount { get; set; }
        public int PlayCount { get; set; }
        public int ProcessStatus { get; set; }
        public int ThumbnailMediaExtension { get; set; }
        public string ThumbnailPath { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public int VideoMediaExtension { get; set; }
        public string VideoPath { get; set; }
        public int VideoStatus { get; set; }
        public int ViewCount { get; set; }
        public int ProcessStep { get; set; }
        public string PlaylistPath { get; set; }

        public AspNetUsers User { get; set; }
        public VideoMapper VideoMapper { get; set; }
        public ICollection<VideoComment> VideoComment { get; set; }
        public ICollection<VideoFavorite> VideoFavorite { get; set; }
        public ICollection<VideoLog> VideoLog { get; set; }
        public ICollection<VideoPlay> VideoPlay { get; set; }
        public ICollection<VideoQuality> VideoQuality { get; set; }
        public ICollection<VideoReport> VideoReport { get; set; }
        public ICollection<VideoVideoCategory> VideoVideoCategory { get; set; }
        public ICollection<VideoVideoTag> VideoVideoTag { get; set; }
        public ICollection<VideoView> VideoView { get; set; }
        public ICollection<VideoVote> VideoVote { get; set; }
    }
}
