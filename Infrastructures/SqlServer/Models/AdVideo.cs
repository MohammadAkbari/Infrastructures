using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AdVideo
    {
        public AdVideo()
        {
            AdVideoClick = new HashSet<AdVideoClick>();
            AdVideoPlay = new HashSet<AdVideoPlay>();
            AdVideoView = new HashSet<AdVideoView>();
        }

        public int AdVideoId { get; set; }
        public int ClickCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public DateTime EndedOn { get; set; }
        public string Link { get; set; }
        public int MediaExtension { get; set; }
        public string Path { get; set; }
        public int Percent { get; set; }
        public int PlayCount { get; set; }
        public DateTime StartedOn { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int ViewCount { get; set; }

        public ICollection<AdVideoClick> AdVideoClick { get; set; }
        public ICollection<AdVideoPlay> AdVideoPlay { get; set; }
        public ICollection<AdVideoView> AdVideoView { get; set; }
    }
}
