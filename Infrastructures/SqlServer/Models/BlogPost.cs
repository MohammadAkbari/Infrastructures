using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class BlogPost
    {
        public BlogPost()
        {
            BlogComment = new HashSet<BlogComment>();
            BlogPostCategory = new HashSet<BlogPostCategory>();
            BlogPostLog = new HashSet<BlogPostLog>();
            BlogPostSource = new HashSet<BlogPostSource>();
            BlogPostTag = new HashSet<BlogPostTag>();
            BlogPostView = new HashSet<BlogPostView>();
            BlogPostVote = new HashSet<BlogPostVote>();
        }

        public int BlogPostId { get; set; }
        public int BlogPostNumber { get; set; }
        public int BlogPostType { get; set; }
        public string Body { get; set; }
        public bool Checkout { get; set; }
        public string CheckoutUserId { get; set; }
        public int CommentCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Headline { get; set; }
        public string Image { get; set; }
        public int LikeCount { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Preface { get; set; }
        public bool Published { get; set; }
        public DateTime? StartUtc { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserId { get; set; }
        public int ViewCount { get; set; }
        public int BlogPostOwnerType { get; set; }
        public string AuthorUserId { get; set; }
        public bool Notified { get; set; }

        public AspNetUsers AuthorUser { get; set; }
        public AspNetUsers CheckoutUser { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<BlogComment> BlogComment { get; set; }
        public ICollection<BlogPostCategory> BlogPostCategory { get; set; }
        public ICollection<BlogPostLog> BlogPostLog { get; set; }
        public ICollection<BlogPostSource> BlogPostSource { get; set; }
        public ICollection<BlogPostTag> BlogPostTag { get; set; }
        public ICollection<BlogPostView> BlogPostView { get; set; }
        public ICollection<BlogPostVote> BlogPostVote { get; set; }
    }
}
