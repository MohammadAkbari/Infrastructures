using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SqlServer.Models
{
    public partial class NiniSiteContext : DbContext
    {
        public virtual DbSet<Ad> Ad { get; set; }
        public virtual DbSet<AdClick> AdClick { get; set; }
        public virtual DbSet<AdHistory> AdHistory { get; set; }
        public virtual DbSet<AdPage> AdPage { get; set; }
        public virtual DbSet<AdVideo> AdVideo { get; set; }
        public virtual DbSet<AdVideoClick> AdVideoClick { get; set; }
        public virtual DbSet<AdVideoPlay> AdVideoPlay { get; set; }
        public virtual DbSet<AdVideoView> AdVideoView { get; set; }
        public virtual DbSet<AdView> AdView { get; set; }
        public virtual DbSet<AdZone> AdZone { get; set; }
        public virtual DbSet<Announcement> Announcement { get; set; }
        public virtual DbSet<ApplicationRole> ApplicationRole { get; set; }
        public virtual DbSet<ApplicationRoleUser> ApplicationRoleUser { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<BadLink> BadLink { get; set; }
        public virtual DbSet<BadWord> BadWord { get; set; }
        public virtual DbSet<BlogCategory> BlogCategory { get; set; }
        public virtual DbSet<BlogCategoryJuncFpCategoryBox> BlogCategoryJuncFpCategoryBox { get; set; }
        public virtual DbSet<BlogCategoryMapper> BlogCategoryMapper { get; set; }
        public virtual DbSet<BlogComment> BlogComment { get; set; }
        public virtual DbSet<BlogCommentMapper> BlogCommentMapper { get; set; }
        public virtual DbSet<BlogCommentVote> BlogCommentVote { get; set; }
        public virtual DbSet<BlogMedia> BlogMedia { get; set; }
        public virtual DbSet<BlogMediaTag> BlogMediaTag { get; set; }
        public virtual DbSet<BlogPost> BlogPost { get; set; }
        public virtual DbSet<BlogPostCategory> BlogPostCategory { get; set; }
        public virtual DbSet<BlogPostLog> BlogPostLog { get; set; }
        public virtual DbSet<BlogPostSource> BlogPostSource { get; set; }
        public virtual DbSet<BlogPostTag> BlogPostTag { get; set; }
        public virtual DbSet<BlogPostView> BlogPostView { get; set; }
        public virtual DbSet<BlogPostVote> BlogPostVote { get; set; }
        public virtual DbSet<BlogTag> BlogTag { get; set; }
        public virtual DbSet<CatIndexdefraglog> CatIndexdefraglog { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClinicCategory> ClinicCategory { get; set; }
        public virtual DbSet<ClinicCategoryConsultant> ClinicCategoryConsultant { get; set; }
        public virtual DbSet<ClinicCategoryFaq> ClinicCategoryFaq { get; set; }
        public virtual DbSet<ClinicCategoryMapper> ClinicCategoryMapper { get; set; }
        public virtual DbSet<ClinicConsultant> ClinicConsultant { get; set; }
        public virtual DbSet<ClinicConsultantAnswer> ClinicConsultantAnswer { get; set; }
        public virtual DbSet<ClinicConsultantAnswerUseful> ClinicConsultantAnswerUseful { get; set; }
        public virtual DbSet<ClinicConsultantMapper> ClinicConsultantMapper { get; set; }
        public virtual DbSet<ClinicDrug> ClinicDrug { get; set; }
        public virtual DbSet<ClinicFaq> ClinicFaq { get; set; }
        public virtual DbSet<ClinicQuestion> ClinicQuestion { get; set; }
        public virtual DbSet<ClinicQuestionComment> ClinicQuestionComment { get; set; }
        public virtual DbSet<ClinicQuestionCommentVote> ClinicQuestionCommentVote { get; set; }
        public virtual DbSet<ClinicQuestionFavorite> ClinicQuestionFavorite { get; set; }
        public virtual DbSet<ClinicQuestionMapper> ClinicQuestionMapper { get; set; }
        public virtual DbSet<ClinicQuestionTag> ClinicQuestionTag { get; set; }
        public virtual DbSet<ClinicQuestionView> ClinicQuestionView { get; set; }
        public virtual DbSet<ClinicQuestionVote> ClinicQuestionVote { get; set; }
        public virtual DbSet<ClinicTag> ClinicTag { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactRequest> ContactRequest { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Conversation> Conversation { get; set; }
        public virtual DbSet<ConversationMapper> ConversationMapper { get; set; }
        public virtual DbSet<ConversationMessage> ConversationMessage { get; set; }
        public virtual DbSet<ConversationMessageState> ConversationMessageState { get; set; }
        public virtual DbSet<ConversationParticipant> ConversationParticipant { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Forum> Forum { get; set; }
        public virtual DbSet<ForumCategory> ForumCategory { get; set; }
        public virtual DbSet<ForumCategoryMapper> ForumCategoryMapper { get; set; }
        public virtual DbSet<ForumClubGroupsMapper> ForumClubGroupsMapper { get; set; }
        public virtual DbSet<ForumMapper> ForumMapper { get; set; }
        public virtual DbSet<ForumModerator> ForumModerator { get; set; }
        public virtual DbSet<ForumPost> ForumPost { get; set; }
        public virtual DbSet<ForumPostClubPostMapper> ForumPostClubPostMapper { get; set; }
        public virtual DbSet<ForumPostEverybodyCanTalkAboutMapper> ForumPostEverybodyCanTalkAboutMapper { get; set; }
        public virtual DbSet<ForumPostFavorite> ForumPostFavorite { get; set; }
        public virtual DbSet<ForumPostLog> ForumPostLog { get; set; }
        public virtual DbSet<ForumPostMapper> ForumPostMapper { get; set; }
        public virtual DbSet<ForumPostReport> ForumPostReport { get; set; }
        public virtual DbSet<ForumPostVote> ForumPostVote { get; set; }
        public virtual DbSet<ForumTopic> ForumTopic { get; set; }
        public virtual DbSet<ForumTopicClubMapper> ForumTopicClubMapper { get; set; }
        public virtual DbSet<ForumTopicDailyViewCount> ForumTopicDailyViewCount { get; set; }
        public virtual DbSet<ForumTopicFavorite> ForumTopicFavorite { get; set; }
        public virtual DbSet<ForumTopicLog> ForumTopicLog { get; set; }
        public virtual DbSet<ForumTopicManager> ForumTopicManager { get; set; }
        public virtual DbSet<ForumTopicMapper> ForumTopicMapper { get; set; }
        public virtual DbSet<ForumTopicMember> ForumTopicMember { get; set; }
        public virtual DbSet<ForumTopicPoll> ForumTopicPoll { get; set; }
        public virtual DbSet<ForumTopicPollLog> ForumTopicPollLog { get; set; }
        public virtual DbSet<ForumTopicPollOption> ForumTopicPollOption { get; set; }
        public virtual DbSet<ForumTopicPollVote> ForumTopicPollVote { get; set; }
        public virtual DbSet<ForumTopicReport> ForumTopicReport { get; set; }
        public virtual DbSet<ForumTopicView> ForumTopicView { get; set; }
        public virtual DbSet<ForumTopicVote> ForumTopicVote { get; set; }
        public virtual DbSet<FpCategoryBox> FpCategoryBox { get; set; }
        public virtual DbSet<Ipblock> Ipblock { get; set; }
        public virtual DbSet<Moderator> Moderator { get; set; }
        public virtual DbSet<Name> Name { get; set; }
        public virtual DbSet<NameMapper> NameMapper { get; set; }
        public virtual DbSet<NameOrigin> NameOrigin { get; set; }
        public virtual DbSet<NameOriginJuncName> NameOriginJuncName { get; set; }
        public virtual DbSet<NameView> NameView { get; set; }
        public virtual DbSet<NameVote> NameVote { get; set; }
        public virtual DbSet<NewsMapper> NewsMapper { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<PhotoCategory> PhotoCategory { get; set; }
        public virtual DbSet<PhotoComment> PhotoComment { get; set; }
        public virtual DbSet<PhotoCommentMapper> PhotoCommentMapper { get; set; }
        public virtual DbSet<PhotoCommentVote> PhotoCommentVote { get; set; }
        public virtual DbSet<PhotoCompetition> PhotoCompetition { get; set; }
        public virtual DbSet<PhotoCompetitionAward> PhotoCompetitionAward { get; set; }
        public virtual DbSet<PhotoCompetitionMapper> PhotoCompetitionMapper { get; set; }
        public virtual DbSet<PhotoCompetitionPhoto> PhotoCompetitionPhoto { get; set; }
        public virtual DbSet<PhotoCompetitionScore> PhotoCompetitionScore { get; set; }
        public virtual DbSet<PhotoCompetitionTag> PhotoCompetitionTag { get; set; }
        public virtual DbSet<PhotoFavorite> PhotoFavorite { get; set; }
        public virtual DbSet<PhotoGallery> PhotoGallery { get; set; }
        public virtual DbSet<PhotoJuncCategory> PhotoJuncCategory { get; set; }
        public virtual DbSet<PhotoJuncTag> PhotoJuncTag { get; set; }
        public virtual DbSet<PhotoLog> PhotoLog { get; set; }
        public virtual DbSet<PhotoMapper> PhotoMapper { get; set; }
        public virtual DbSet<PhotoReport> PhotoReport { get; set; }
        public virtual DbSet<PhotoTag> PhotoTag { get; set; }
        public virtual DbSet<PhotoTagMapper> PhotoTagMapper { get; set; }
        public virtual DbSet<PhotoView> PhotoView { get; set; }
        public virtual DbSet<PhotoVote> PhotoVote { get; set; }
        public virtual DbSet<PregnancyTicker> PregnancyTicker { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<SlideShow> SlideShow { get; set; }
        public virtual DbSet<Timeline> Timeline { get; set; }
        public virtual DbSet<TimelineComment> TimelineComment { get; set; }
        public virtual DbSet<TimelineCommentVote> TimelineCommentVote { get; set; }
        public virtual DbSet<UserChild> UserChild { get; set; }
        public virtual DbSet<UserEmbryo> UserEmbryo { get; set; }
        public virtual DbSet<UserLoginHistory> UserLoginHistory { get; set; }
        public virtual DbSet<UserMapper> UserMapper { get; set; }
        public virtual DbSet<UserPicture> UserPicture { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<VideoCategory> VideoCategory { get; set; }
        public virtual DbSet<VideoCategoryMapper> VideoCategoryMapper { get; set; }
        public virtual DbSet<VideoComment> VideoComment { get; set; }
        public virtual DbSet<VideoCommentMapper> VideoCommentMapper { get; set; }
        public virtual DbSet<VideoCommentVote> VideoCommentVote { get; set; }
        public virtual DbSet<VideoFavorite> VideoFavorite { get; set; }
        public virtual DbSet<VideoLog> VideoLog { get; set; }
        public virtual DbSet<VideoMapper> VideoMapper { get; set; }
        public virtual DbSet<VideoPlay> VideoPlay { get; set; }
        public virtual DbSet<VideoQuality> VideoQuality { get; set; }
        public virtual DbSet<VideoReport> VideoReport { get; set; }
        public virtual DbSet<VideoTag> VideoTag { get; set; }
        public virtual DbSet<VideoVideoCategory> VideoVideoCategory { get; set; }
        public virtual DbSet<VideoVideoTag> VideoVideoTag { get; set; }
        public virtual DbSet<VideoView> VideoView { get; set; }
        public virtual DbSet<VideoVote> VideoVote { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=192.168.20.80;Initial Catalog=NiniSite;User ID=NiniSite;Password=NiniSite321;TrustServerCertificate=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ad>(entity =>
            {
                entity.HasIndex(e => e.AdZoneId);

                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170418");

                entity.HasIndex(e => new { e.StartedOn, e.EndedOn, e.Deleted })
                    .HasName("UIX-StartEndDelete-20170418");

                entity.HasOne(d => d.AdZone)
                    .WithMany(p => p.Ad)
                    .HasForeignKey(d => d.AdZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AdClick>(entity =>
            {
                entity.HasIndex(e => e.AdId);

                entity.HasOne(d => d.Ad)
                    .WithMany(p => p.AdClick)
                    .HasForeignKey(d => d.AdId);
            });

            modelBuilder.Entity<AdHistory>(entity =>
            {
                entity.HasIndex(e => e.AdId);

                entity.Property(e => e.AdPage).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdPageId).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdZone).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClickCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Ad)
                    .WithMany(p => p.AdHistory)
                    .HasForeignKey(d => d.AdId);
            });

            modelBuilder.Entity<AdPage>(entity =>
            {
                entity.HasIndex(e => e.Page)
                    .HasName("UIX-Page-20170418");
            });

            modelBuilder.Entity<AdVideoClick>(entity =>
            {
                entity.HasIndex(e => e.AdVideoId);

                entity.HasOne(d => d.AdVideo)
                    .WithMany(p => p.AdVideoClick)
                    .HasForeignKey(d => d.AdVideoId);
            });

            modelBuilder.Entity<AdVideoPlay>(entity =>
            {
                entity.HasIndex(e => e.AdVideoId);

                entity.HasOne(d => d.AdVideo)
                    .WithMany(p => p.AdVideoPlay)
                    .HasForeignKey(d => d.AdVideoId);
            });

            modelBuilder.Entity<AdVideoView>(entity =>
            {
                entity.HasIndex(e => e.AdVideoId);

                entity.HasOne(d => d.AdVideo)
                    .WithMany(p => p.AdVideoView)
                    .HasForeignKey(d => d.AdVideoId);
            });

            modelBuilder.Entity<AdView>(entity =>
            {
                entity.HasIndex(e => e.AdId);

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Ad)
                    .WithMany(p => p.AdView)
                    .HasForeignKey(d => d.AdId);
            });

            modelBuilder.Entity<AdZone>(entity =>
            {
                entity.HasIndex(e => e.AdPageId);

                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170418");

                entity.HasIndex(e => e.Zone)
                    .HasName("UIX-Zone-20170418");

                entity.Property(e => e.AdZoneType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AdPage)
                    .WithMany(p => p.AdZone)
                    .HasForeignKey(d => d.AdPageId);
            });

            modelBuilder.Entity<ApplicationRoleUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ApplicationRoleId });

                entity.HasIndex(e => e.ApplicationRoleId);

                entity.HasOne(d => d.ApplicationRole)
                    .WithMany(p => p.ApplicationRoleUser)
                    .HasForeignKey(d => d.ApplicationRoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApplicationRoleUser)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.CreatedOn)
                    .HasName("ras_AspNetUsers_Deleted");

                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170418");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.HasIndex(e => e.ProfileCompleted)
                    .HasName("UIX-Pofile-20170415");

                entity.HasIndex(e => new { e.UserName, e.Deleted })
                    .HasName("UIX-DELETED-USERNAME");

                entity.HasIndex(e => new { e.Id, e.ForumPostCount, e.CreatedOn, e.Avatar, e.Nickname, e.Signature, e.Deleted })
                    .HasName("uix_Deleted");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Avatar).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Nickname).HasColumnType("nvarchar(max)");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.Signature).HasColumnType("nvarchar(max)");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<BlogCategory>(entity =>
            {
                entity.HasIndex(e => e.Deleted);

                entity.HasIndex(e => e.DisplayOrder)
                    .HasName("UIX-DisplayOrder-20170415");

                entity.HasIndex(e => e.ParentCategoryId);

                entity.HasIndex(e => new { e.DisplayOrder, e.Deleted })
                    .HasName("UIXF-DeletedDispalyOrder-20170418")
                    .HasFilter("([Deleted]=(0))");

                entity.HasIndex(e => new { e.BlogCategoryId, e.Name, e.ParentCategoryId, e.CoverPath, e.Icon, e.Deleted, e.DisplayOrder })
                    .HasName("UIX-DeletedDisplayOrder-20170418");

                entity.Property(e => e.CoverPath).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Icon).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Name).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId);
            });

            modelBuilder.Entity<BlogCategoryJuncFpCategoryBox>(entity =>
            {
                entity.HasKey(e => new { e.FpCategoryBoxId, e.BlogCategoryId });

                entity.HasIndex(e => e.BlogCategoryId);

                entity.HasOne(d => d.BlogCategory)
                    .WithMany(p => p.BlogCategoryJuncFpCategoryBox)
                    .HasForeignKey(d => d.BlogCategoryId);

                entity.HasOne(d => d.FpCategoryBox)
                    .WithMany(p => p.BlogCategoryJuncFpCategoryBox)
                    .HasForeignKey(d => d.FpCategoryBoxId);
            });

            modelBuilder.Entity<BlogCategoryMapper>(entity =>
            {
                entity.HasIndex(e => e.BlogCategoryId);

                entity.Property(e => e.BlogCategoryMapperId).ValueGeneratedNever();

                entity.HasOne(d => d.BlogCategory)
                    .WithMany(p => p.BlogCategoryMapper)
                    .HasForeignKey(d => d.BlogCategoryId);
            });

            modelBuilder.Entity<BlogComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.HasIndex(e => e.ParentCommentId);

                entity.HasIndex(e => e.TargetId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.ParentComment)
                    .WithMany(p => p.InverseParentComment)
                    .HasForeignKey(d => d.ParentCommentId);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.TargetId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BlogCommentMapper>(entity =>
            {
                entity.HasKey(e => e.BlogCommentId);

                entity.HasIndex(e => e.CommentId);

                entity.Property(e => e.BlogCommentId).ValueGeneratedNever();

                entity.HasOne(d => d.BlogComment)
                    .WithOne(p => p.BlogCommentMapper)
                    .HasForeignKey<BlogCommentMapper>(d => d.BlogCommentId);
            });

            modelBuilder.Entity<BlogCommentVote>(entity =>
            {
                entity.HasKey(e => e.CommentVoteId);

                entity.HasIndex(e => e.CommentId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.BlogCommentVote)
                    .HasForeignKey(d => d.CommentId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BlogCommentVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BlogMediaTag>(entity =>
            {
                entity.HasKey(e => new { e.BlogMediaId, e.BlogTagId });

                entity.HasIndex(e => e.BlogTagId);

                entity.HasOne(d => d.BlogMedia)
                    .WithMany(p => p.BlogMediaTag)
                    .HasForeignKey(d => d.BlogMediaId);

                entity.HasOne(d => d.BlogTag)
                    .WithMany(p => p.BlogMediaTag)
                    .HasForeignKey(d => d.BlogTagId);
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.HasIndex(e => e.AuthorUserId);

                entity.HasIndex(e => e.CheckoutUserId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.StartUtc, e.Deleted })
                    .HasName("UIXF-StartDeleted-20170418")
                    .HasFilter("([BlogPostType]=(2) AND [Published]=(1) AND [Deleted]=(0))");

                entity.HasIndex(e => new { e.BlogPostId, e.Deleted, e.Published })
                    .HasName("ras_BlogPost_Deleted");

                entity.HasIndex(e => new { e.BlogPostId, e.BlogPostType, e.Published, e.Deleted, e.StartUtc })
                    .HasName("UIX-IdTypePublishedDeletedStart-20170418");

                entity.HasIndex(e => new { e.Title, e.Image, e.ViewCount, e.BlogPostId, e.Deleted, e.Published, e.StartUtc })
                    .HasName("UIX-20170531-175243");

                entity.HasIndex(e => new { e.BlogPostId, e.Image, e.Title, e.ViewCount, e.BlogPostOwnerType, e.BlogPostType, e.Deleted, e.Published, e.StartUtc })
                    .HasName("MIX_");

                entity.Property(e => e.Image).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Title).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.AuthorUser)
                    .WithMany(p => p.BlogPostAuthorUser)
                    .HasForeignKey(d => d.AuthorUserId);

                entity.HasOne(d => d.CheckoutUser)
                    .WithMany(p => p.BlogPostCheckoutUser)
                    .HasForeignKey(d => d.CheckoutUserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BlogPostUser)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BlogPostCategory>(entity =>
            {
                entity.HasKey(e => new { e.BlogPostId, e.BlogCategoryId });

                entity.HasIndex(e => e.BlogCategoryId);

                entity.HasOne(d => d.BlogCategory)
                    .WithMany(p => p.BlogPostCategory)
                    .HasForeignKey(d => d.BlogCategoryId);

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostCategory)
                    .HasForeignKey(d => d.BlogPostId);
            });

            modelBuilder.Entity<BlogPostLog>(entity =>
            {
                entity.HasIndex(e => e.BlogPostId);

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostLog)
                    .HasForeignKey(d => d.BlogPostId);
            });

            modelBuilder.Entity<BlogPostSource>(entity =>
            {
                entity.HasIndex(e => e.BlogPostId);

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostSource)
                    .HasForeignKey(d => d.BlogPostId);
            });

            modelBuilder.Entity<BlogPostTag>(entity =>
            {
                entity.HasKey(e => new { e.BlogPostId, e.BlogTagId });

                entity.HasIndex(e => e.BlogTagId);

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostTag)
                    .HasForeignKey(d => d.BlogPostId);

                entity.HasOne(d => d.BlogTag)
                    .WithMany(p => p.BlogPostTag)
                    .HasForeignKey(d => d.BlogTagId);
            });

            modelBuilder.Entity<BlogPostView>(entity =>
            {
                entity.HasIndex(e => e.BlogPostId);

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostView)
                    .HasForeignKey(d => d.BlogPostId);
            });

            modelBuilder.Entity<BlogPostVote>(entity =>
            {
                entity.HasIndex(e => e.BlogPostId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostVote)
                    .HasForeignKey(d => d.BlogPostId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BlogPostVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CatIndexdefraglog>(entity =>
            {
                entity.ToTable("cat_indexdefraglog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommandText)
                    .IsRequired()
                    .HasColumnName("command_text");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExecutionId).HasColumnName("execution_id");

                entity.Property(e => e.Fragmentation).HasColumnName("fragmentation");

                entity.Property(e => e.IndexName)
                    .HasColumnName("index_name")
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(512);

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SucceedState).HasColumnName("succeed_state");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.ProvinceId);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.ProvinceId);
            });

            modelBuilder.Entity<ClinicCategory>(entity =>
            {
                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170418");

                entity.HasIndex(e => e.DisplayOrder)
                    .HasName("UIX-DisplayOrder-20170415");

                entity.HasIndex(e => e.ParentCategoryId);

                entity.HasIndex(e => new { e.ClinicCategoryId, e.Deleted })
                    .HasName("UIXF-CategoryIdDeleted-20170418")
                    .HasFilter("([deleted]=(0))");

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId);
            });

            modelBuilder.Entity<ClinicCategoryConsultant>(entity =>
            {
                entity.HasKey(e => new { e.ClinicCategoryId, e.ClinicConsultantId });

                entity.HasIndex(e => e.ClinicConsultantId);

                entity.HasOne(d => d.ClinicCategory)
                    .WithMany(p => p.ClinicCategoryConsultant)
                    .HasForeignKey(d => d.ClinicCategoryId);

                entity.HasOne(d => d.ClinicConsultant)
                    .WithMany(p => p.ClinicCategoryConsultant)
                    .HasForeignKey(d => d.ClinicConsultantId);
            });

            modelBuilder.Entity<ClinicCategoryFaq>(entity =>
            {
                entity.HasKey(e => new { e.ClinicCategoryId, e.ClinicFaqId });

                entity.HasIndex(e => e.ClinicFaqId);

                entity.HasOne(d => d.ClinicCategory)
                    .WithMany(p => p.ClinicCategoryFaq)
                    .HasForeignKey(d => d.ClinicCategoryId);

                entity.HasOne(d => d.ClinicFaq)
                    .WithMany(p => p.ClinicCategoryFaq)
                    .HasForeignKey(d => d.ClinicFaqId);
            });

            modelBuilder.Entity<ClinicCategoryMapper>(entity =>
            {
                entity.HasKey(e => e.ClinicCategoryId);

                entity.Property(e => e.ClinicCategoryId).ValueGeneratedNever();

                entity.HasOne(d => d.ClinicCategory)
                    .WithOne(p => p.ClinicCategoryMapper)
                    .HasForeignKey<ClinicCategoryMapper>(d => d.ClinicCategoryId);
            });

            modelBuilder.Entity<ClinicConsultant>(entity =>
            {
                entity.Property(e => e.ClinicConsultantId).ValueGeneratedNever();

                entity.HasOne(d => d.ClinicConsultantNavigation)
                    .WithOne(p => p.ClinicConsultant)
                    .HasForeignKey<ClinicConsultant>(d => d.ClinicConsultantId);
            });

            modelBuilder.Entity<ClinicConsultantAnswer>(entity =>
            {
                entity.HasIndex(e => e.ClinicConsultantId);

                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170418");

                entity.HasIndex(e => new { e.ClinicConsultantAnswerId, e.ClinicConsultantId, e.Deleted })
                    .HasName("ras_ClinicConsultantAnswer_Deleted");

                entity.Property(e => e.ClinicConsultantAnswerId).ValueGeneratedNever();

                entity.HasOne(d => d.ClinicConsultantAnswerNavigation)
                    .WithOne(p => p.ClinicConsultantAnswer)
                    .HasForeignKey<ClinicConsultantAnswer>(d => d.ClinicConsultantAnswerId);

                entity.HasOne(d => d.ClinicConsultant)
                    .WithMany(p => p.ClinicConsultantAnswer)
                    .HasForeignKey(d => d.ClinicConsultantId);
            });

            modelBuilder.Entity<ClinicConsultantAnswerUseful>(entity =>
            {
                entity.HasKey(e => new { e.ClinicConsultantAnswerId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.ClinicConsultantAnswer)
                    .WithMany(p => p.ClinicConsultantAnswerUseful)
                    .HasForeignKey(d => d.ClinicConsultantAnswerId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClinicConsultantAnswerUseful)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ClinicConsultantMapper>(entity =>
            {
                entity.HasKey(e => e.ClinicConsultantId);

                entity.Property(e => e.ClinicConsultantId).ValueGeneratedNever();

                entity.HasOne(d => d.ClinicConsultant)
                    .WithOne(p => p.ClinicConsultantMapper)
                    .HasForeignKey<ClinicConsultantMapper>(d => d.ClinicConsultantId);
            });

            modelBuilder.Entity<ClinicQuestion>(entity =>
            {
                entity.HasIndex(e => e.AnsweredOn)
                    .HasName("UIXF-AnsweredOn-20170418")
                    .HasFilter("([Deleted]=(0) AND [IsConfirmed]=(1) AND [QuestionStatus]=(3))");

                entity.HasIndex(e => e.ClinicCategoryId);

                entity.HasIndex(e => e.ClinicConsultantId);

                entity.HasIndex(e => e.QuestionerUserId);

                entity.HasIndex(e => new { e.ClinicCategoryId, e.CreatedOn })
                    .HasName("NonClusteredIndex-20171129-091621");

                entity.HasIndex(e => new { e.ClinicQuestionId, e.Title, e.CreatedOn })
                    .HasName("UIXF-ConFirmedDeletedStatus2-20170418")
                    .HasFilter("([IsConfirmed]=(1) AND [Deleted]=(0) AND [QuestionStatus]<>(3))");

                entity.HasIndex(e => new { e.ClinicQuestionId, e.ClinicCategoryId, e.QuestionerUserId, e.Deleted, e.IsConfirmed, e.QuestionStatus })
                    .HasName("ras_ClinicQuestion_Deleted");

                entity.HasIndex(e => new { e.ClinicQuestionId, e.Title, e.ClinicCategoryId, e.CreatedOn, e.Deleted, e.IsConfirmed, e.QuestionStatus })
                    .HasName("UIXF-ConFirmedDeletedStatus3-20170418")
                    .HasFilter("([IsConfirmed]=(1) AND [Deleted]=(0) AND [QuestionStatus]=(3))");

                entity.HasIndex(e => new { e.ClinicQuestionId, e.AnsweredOn, e.Title, e.QuestionerUserId, e.ClinicCategoryId, e.Deleted, e.IsConfirmed, e.QuestionStatus })
                    .HasName("ras_ClinicQuestion_ClinicCategoryId");

                entity.Property(e => e.CommentCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.LikeCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.ClinicCategory)
                    .WithMany(p => p.ClinicQuestion)
                    .HasForeignKey(d => d.ClinicCategoryId);

                entity.HasOne(d => d.ClinicConsultant)
                    .WithMany(p => p.ClinicQuestion)
                    .HasForeignKey(d => d.ClinicConsultantId);

                entity.HasOne(d => d.QuestionerUser)
                    .WithMany(p => p.ClinicQuestion)
                    .HasForeignKey(d => d.QuestionerUserId);
            });

            modelBuilder.Entity<ClinicQuestionComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.HasIndex(e => e.ParentCommentId);

                entity.HasIndex(e => e.TargetId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.ParentComment)
                    .WithMany(p => p.InverseParentComment)
                    .HasForeignKey(d => d.ParentCommentId);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.ClinicQuestionComment)
                    .HasForeignKey(d => d.TargetId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClinicQuestionComment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ClinicQuestionCommentVote>(entity =>
            {
                entity.HasKey(e => e.CommentVoteId);

                entity.HasIndex(e => e.CommentId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.ClinicQuestionCommentVote)
                    .HasForeignKey(d => d.CommentId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClinicQuestionCommentVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ClinicQuestionFavorite>(entity =>
            {
                entity.HasKey(e => new { e.ClinicQuestionId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.ClinicQuestion)
                    .WithMany(p => p.ClinicQuestionFavorite)
                    .HasForeignKey(d => d.ClinicQuestionId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClinicQuestionFavorite)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ClinicQuestionMapper>(entity =>
            {
                entity.HasKey(e => e.ClinicQuestionId);

                entity.HasIndex(e => e.OldQuestionId)
                    .HasName("ras_ClinicQuestionMapper_OldQuestionId");

                entity.Property(e => e.ClinicQuestionId).ValueGeneratedNever();

                entity.HasOne(d => d.ClinicQuestion)
                    .WithOne(p => p.ClinicQuestionMapper)
                    .HasForeignKey<ClinicQuestionMapper>(d => d.ClinicQuestionId);
            });

            modelBuilder.Entity<ClinicQuestionTag>(entity =>
            {
                entity.HasKey(e => new { e.ClinicQuestionId, e.ClinicTagId });

                entity.HasIndex(e => e.ClinicTagId);

                entity.HasOne(d => d.ClinicQuestion)
                    .WithMany(p => p.ClinicQuestionTag)
                    .HasForeignKey(d => d.ClinicQuestionId);

                entity.HasOne(d => d.ClinicTag)
                    .WithMany(p => p.ClinicQuestionTag)
                    .HasForeignKey(d => d.ClinicTagId);
            });

            modelBuilder.Entity<ClinicQuestionView>(entity =>
            {
                entity.HasIndex(e => e.ClinicQuestionId);

                entity.HasIndex(e => new { e.ClinicQuestionId, e.ViewCount, e.DayDate })
                    .HasName("ras_ClinicQuestionView_DayDate");

                entity.HasOne(d => d.ClinicQuestion)
                    .WithMany(p => p.ClinicQuestionView)
                    .HasForeignKey(d => d.ClinicQuestionId);
            });

            modelBuilder.Entity<ClinicQuestionVote>(entity =>
            {
                entity.HasKey(e => new { e.ClinicQuestionId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.ClinicQuestion)
                    .WithMany(p => p.ClinicQuestionVote)
                    .HasForeignKey(d => d.ClinicQuestionId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClinicQuestionVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => e.AddresseeId);

                entity.HasIndex(e => e.RequesterId);

                entity.HasOne(d => d.Addressee)
                    .WithMany(p => p.ContactAddressee)
                    .HasForeignKey(d => d.AddresseeId);

                entity.HasOne(d => d.Requester)
                    .WithMany(p => p.ContactRequester)
                    .HasForeignKey(d => d.RequesterId);
            });

            modelBuilder.Entity<ContactRequest>(entity =>
            {
                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactRequest)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactRequest)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Conversation)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ConversationMapper>(entity =>
            {
                entity.HasKey(e => e.ConversationId);

                entity.Property(e => e.ConversationId).ValueGeneratedNever();

                entity.HasOne(d => d.Conversation)
                    .WithOne(p => p.ConversationMapper)
                    .HasForeignKey<ConversationMapper>(d => d.ConversationId);
            });

            modelBuilder.Entity<ConversationMessage>(entity =>
            {
                entity.HasIndex(e => e.ConversationId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.ConversationMessage)
                    .HasForeignKey(d => d.ConversationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConversationMessage)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ConversationMessageState>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ConversationMessageId });

                entity.HasIndex(e => e.ConversationMessageId);

                entity.HasOne(d => d.ConversationMessage)
                    .WithMany(p => p.ConversationMessageState)
                    .HasForeignKey(d => d.ConversationMessageId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConversationMessageState)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ConversationParticipant>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ConversationId });

                entity.HasIndex(e => e.ConversationId);

                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170415");

                entity.HasIndex(e => e.Read)
                    .HasName("UIX-Read-20170415");

                entity.HasIndex(e => e.Received)
                    .HasName("UIX-Recieved-20170415");

                entity.HasIndex(e => new { e.Read, e.Received, e.Deleted })
                    .HasName("UIX-ReadRecievedDeleted-20170415");

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.ConversationParticipant)
                    .HasForeignKey(d => d.ConversationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConversationParticipant)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Forum>(entity =>
            {
                entity.HasIndex(e => e.CreatedOn);

                entity.HasIndex(e => e.ForumCategoryId);

                entity.HasIndex(e => new { e.Inactive, e.Deleted })
                    .HasName("NonClusteredIndex-20170425-172735")
                    .HasFilter("([Inactive]=(0) AND [Deleted]=(0))");

                entity.HasOne(d => d.ForumCategory)
                    .WithMany(p => p.Forum)
                    .HasForeignKey(d => d.ForumCategoryId);
            });

            modelBuilder.Entity<ForumCategory>(entity =>
            {
                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170418");

                entity.HasIndex(e => new { e.DisplayOrder, e.Deleted })
                    .HasName("UIXF-Deleted-20170418")
                    .HasFilter("([Deleted]=(0))");

                entity.HasIndex(e => new { e.Inactive, e.Deleted })
                    .HasName("UIXF-InActiveDeleted-20170418")
                    .HasFilter("([Inactive]=(0) AND [Deleted]=(0))");
            });

            modelBuilder.Entity<ForumCategoryMapper>(entity =>
            {
                entity.HasKey(e => e.ForumCategoryId);

                entity.HasIndex(e => e.OldForumCategoryId);

                entity.Property(e => e.ForumCategoryId).ValueGeneratedNever();

                entity.HasOne(d => d.ForumCategory)
                    .WithOne(p => p.ForumCategoryMapper)
                    .HasForeignKey<ForumCategoryMapper>(d => d.ForumCategoryId);
            });

            modelBuilder.Entity<ForumClubGroupsMapper>(entity =>
            {
                entity.HasKey(e => e.ForumId);

                entity.HasIndex(e => e.ClubGroupId);

                entity.Property(e => e.ForumId).ValueGeneratedNever();

                entity.HasOne(d => d.Forum)
                    .WithOne(p => p.ForumClubGroupsMapper)
                    .HasForeignKey<ForumClubGroupsMapper>(d => d.ForumId);
            });

            modelBuilder.Entity<ForumMapper>(entity =>
            {
                entity.HasKey(e => e.ForumId);

                entity.HasIndex(e => e.OldForumId);

                entity.Property(e => e.ForumId).ValueGeneratedNever();

                entity.HasOne(d => d.Forum)
                    .WithOne(p => p.ForumMapper)
                    .HasForeignKey<ForumMapper>(d => d.ForumId);
            });

            modelBuilder.Entity<ForumModerator>(entity =>
            {
                entity.HasKey(e => new { e.ForumId, e.ModeratorId });

                entity.HasIndex(e => e.ModeratorId);

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumModerator)
                    .HasForeignKey(d => d.ForumId);

                entity.HasOne(d => d.Moderator)
                    .WithMany(p => p.ForumModerator)
                    .HasForeignKey(d => d.ModeratorId);
            });

            modelBuilder.Entity<ForumPost>(entity =>
            {
                entity.HasIndex(e => e.CreatedOn);

                entity.HasIndex(e => e.ForumTopicId);

                entity.HasIndex(e => e.ReplyForumPostId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.ForumTopicId, e.CreatedOn })
                    .HasName("ras_ForumPost_ForumTopicId");

                entity.HasIndex(e => new { e.Deleted, e.ForumPostState, e.ReportCount })
                    .HasName("ras_ForumPost_Deleted_ForumPostState");

                entity.HasIndex(e => new { e.UserId, e.ForumTopicId, e.Deleted })
                    .HasName("NonClusteredIndex-20170510-184959")
                    .HasFilter("([Deleted]=(0))");

                entity.HasIndex(e => new { e.CreatedOn, e.ForumPostId, e.ForumTopicId, e.Deleted, e.ForumPostState })
                    .HasName("uix_CreatedOn");

                entity.HasIndex(e => new { e.ForumPostId, e.ForumPostState, e.Message, e.Deleted, e.IsTopicPost, e.CreatedOn })
                    .HasName("UIX-DELETEDISTOPICPOST-20170526-190240");

                entity.HasIndex(e => new { e.ForumPostId, e.ForumTopicId, e.LikeCount, e.ReplyCount, e.Message, e.UserId, e.ForumPostState, e.Deleted, e.IsTopicPost, e.CreatedOn })
                    .HasName("NonClusteredIndex-20170430-135935");

                entity.HasIndex(e => new { e.ForumPostId, e.CreatedOn, e.IncludeFile, e.LikeCount, e.Message, e.ModeratorPost, e.ReplyCount, e.ReplyForumPostId, e.UserId, e.IsTopicPost, e.Deleted, e.ForumPostState, e.ForumTopicId })
                    .HasName("MIX_TopicIdDeletedForumPostState");

                entity.HasIndex(e => new { e.ForumPostId, e.CreatedOn, e.IncludeFile, e.LikeCount, e.Message, e.ModeratorPost, e.ReplyCount, e.ReplyForumPostId, e.UserId, e.IsTopicPost, e.Deleted, e.ForumTopicId, e.ForumPostState })
                    .HasName("UIX-MiS-4-26-2017");

                entity.HasIndex(e => new { e.ForumPostId, e.IncludeFile, e.LikeCount, e.Message, e.ModeratorPost, e.ReplyCount, e.ReplyForumPostId, e.UserId, e.IsTopicPost, e.Deleted, e.ForumPostState, e.ForumTopicId, e.CreatedOn })
                    .HasName("MIX_TopicIdDeletedForumPostStateIncludeDetails");

                entity.HasIndex(e => new { e.ForumPostId, e.CreatedOn, e.DislikeCount, e.IncludeFile, e.LikeCount, e.Message, e.ModeratorPost, e.ReplyCount, e.ReplyForumPostId, e.ReportCount, e.UpdatedOn, e.UserId, e.IsTopicPost, e.Deleted, e.ForumTopicId, e.ForumPostState })
                    .HasName("UIX-INCLUDE-EveryThing");

                entity.Property(e => e.Message).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumPost)
                    .HasForeignKey(d => d.ForumTopicId);

                entity.HasOne(d => d.ReplyForumPost)
                    .WithMany(p => p.InverseReplyForumPost)
                    .HasForeignKey(d => d.ReplyForumPostId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumPost)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ForumPostClubPostMapper>(entity =>
            {
                entity.HasKey(e => e.ForumPostId);

                entity.HasIndex(e => e.ClubPostId);

                entity.Property(e => e.ForumPostId).ValueGeneratedNever();

                entity.HasOne(d => d.ForumPost)
                    .WithOne(p => p.ForumPostClubPostMapper)
                    .HasForeignKey<ForumPostClubPostMapper>(d => d.ForumPostId);
            });

            modelBuilder.Entity<ForumPostEverybodyCanTalkAboutMapper>(entity =>
            {
                entity.HasKey(e => e.ForumPostId);

                entity.Property(e => e.ForumPostId).ValueGeneratedNever();

                entity.HasOne(d => d.ForumPost)
                    .WithOne(p => p.ForumPostEverybodyCanTalkAboutMapper)
                    .HasForeignKey<ForumPostEverybodyCanTalkAboutMapper>(d => d.ForumPostId);
            });

            modelBuilder.Entity<ForumPostFavorite>(entity =>
            {
                entity.HasKey(e => new { e.ForumPostId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.ForumPostId, e.CreatedOn, e.UserId })
                    .HasName("UIX-20170503-182355");

                entity.HasOne(d => d.ForumPost)
                    .WithMany(p => p.ForumPostFavorite)
                    .HasForeignKey(d => d.ForumPostId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumPostFavorite)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ForumPostLog>(entity =>
            {
                entity.HasIndex(e => e.ForumPostId);

                entity.HasOne(d => d.ForumPost)
                    .WithMany(p => p.ForumPostLog)
                    .HasForeignKey(d => d.ForumPostId);
            });

            modelBuilder.Entity<ForumPostMapper>(entity =>
            {
                entity.HasKey(e => e.ForumPostId);

                entity.HasIndex(e => e.OldForumPostId);

                entity.Property(e => e.ForumPostId).ValueGeneratedNever();

                entity.HasOne(d => d.ForumPost)
                    .WithOne(p => p.ForumPostMapper)
                    .HasForeignKey<ForumPostMapper>(d => d.ForumPostId);
            });

            modelBuilder.Entity<ForumPostReport>(entity =>
            {
                entity.HasIndex(e => e.ForumPostId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.ZappedUserId);

                entity.HasOne(d => d.ForumPost)
                    .WithMany(p => p.ForumPostReport)
                    .HasForeignKey(d => d.ForumPostId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumPostReportUser)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.ZappedUser)
                    .WithMany(p => p.ForumPostReportZappedUser)
                    .HasForeignKey(d => d.ZappedUserId);
            });

            modelBuilder.Entity<ForumPostVote>(entity =>
            {
                entity.HasKey(e => new { e.ForumPostId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.ForumPostId, e.CreatedOn, e.UserId })
                    .HasName("UIX-20170503-181452");

                entity.HasOne(d => d.ForumPost)
                    .WithMany(p => p.ForumPostVote)
                    .HasForeignKey(d => d.ForumPostId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumPostVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ForumTopic>(entity =>
            {
                entity.HasIndex(e => e.CreatedOn)
                    .HasName("UIX_ForumTopic_FilteredLastCreatedOn")
                    .HasFilter("([Deleted]=(0) AND [ForumTopicState]<>(2))");

                entity.HasIndex(e => e.Deleted)
                    .HasName("NonClusteredIndex-20170425-172436")
                    .HasFilter("([Deleted]=(0))");

                entity.HasIndex(e => e.ForumId);

                entity.HasIndex(e => e.LastRepliedOn)
                    .HasName("UIX_ForumTopic_FilteredLastRepliedOn")
                    .HasFilter("([Deleted]=(0) AND [ForumTopicState]<>(2) AND [LastReplyId] IS NOT NULL)");

                entity.HasIndex(e => e.UpdatedOn);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.Deleted, e.ForumTopicState, e.ForumId })
                    .HasName("NonClusteredIndex-DeleteForumTopicState");

                entity.HasIndex(e => new { e.Deleted, e.ForumTopicState, e.ReportCount })
                    .HasName("ras_ForumTopic_Deleted_ForumTopicState");

                entity.HasIndex(e => new { e.ForumId, e.ShowInAllForum, e.Deleted, e.ForumTopicState })
                    .HasName("MIX_DeletedForumTopicState");

                entity.HasIndex(e => new { e.ForumTopicState, e.Subject, e.Deleted, e.LastReplyId })
                    .HasName("UIX-INC-DELLASTREPLY-05262017");

                entity.Property(e => e.LikeCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenCloseState).HasDefaultValueSql("((0))");

                entity.Property(e => e.Subject).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumTopic)
                    .HasForeignKey(d => d.ForumId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumTopic)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ForumTopicClubMapper>(entity =>
            {
                entity.HasKey(e => e.ForumTopicId);

                entity.HasIndex(e => e.ClubId);

                entity.Property(e => e.ForumTopicId).ValueGeneratedNever();

                entity.HasOne(d => d.ForumTopic)
                    .WithOne(p => p.ForumTopicClubMapper)
                    .HasForeignKey<ForumTopicClubMapper>(d => d.ForumTopicId);
            });

            modelBuilder.Entity<ForumTopicDailyViewCount>(entity =>
            {
                entity.HasKey(e => new { e.ForumTopicId, e.Date });

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumTopicDailyViewCount)
                    .HasForeignKey(d => d.ForumTopicId);
            });

            modelBuilder.Entity<ForumTopicFavorite>(entity =>
            {
                entity.HasKey(e => new { e.ForumTopicId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumTopicFavorite)
                    .HasForeignKey(d => d.ForumTopicId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumTopicFavorite)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ForumTopicLog>(entity =>
            {
                entity.HasIndex(e => e.ForumTopicId);

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumTopicLog)
                    .HasForeignKey(d => d.ForumTopicId);
            });

            modelBuilder.Entity<ForumTopicManager>(entity =>
            {
                entity.HasKey(e => new { e.ForumTopicId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumTopicManager)
                    .HasForeignKey(d => d.ForumTopicId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumTopicManager)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ForumTopicMapper>(entity =>
            {
                entity.HasKey(e => e.ForumTopicId);

                entity.HasIndex(e => e.OldForumTopicId);

                entity.Property(e => e.ForumTopicId).ValueGeneratedNever();

                entity.HasOne(d => d.ForumTopic)
                    .WithOne(p => p.ForumTopicMapper)
                    .HasForeignKey<ForumTopicMapper>(d => d.ForumTopicId);
            });

            modelBuilder.Entity<ForumTopicMember>(entity =>
            {
                entity.HasIndex(e => e.CallerId);

                entity.HasIndex(e => e.ForumTopicId);

                entity.HasIndex(e => e.MemberId);

                entity.HasIndex(e => new { e.Deleted, e.Accept })
                    .HasName("NonClusteredIndex-20170425-174918");

                entity.HasOne(d => d.Caller)
                    .WithMany(p => p.ForumTopicMemberCaller)
                    .HasForeignKey(d => d.CallerId);

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumTopicMember)
                    .HasForeignKey(d => d.ForumTopicId);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.ForumTopicMemberMember)
                    .HasForeignKey(d => d.MemberId);
            });

            modelBuilder.Entity<ForumTopicPoll>(entity =>
            {
                entity.Property(e => e.ForumTopicPollId).ValueGeneratedNever();

                entity.HasOne(d => d.ForumTopicPollNavigation)
                    .WithOne(p => p.ForumTopicPoll)
                    .HasForeignKey<ForumTopicPoll>(d => d.ForumTopicPollId);
            });

            modelBuilder.Entity<ForumTopicPollLog>(entity =>
            {
                entity.HasIndex(e => e.ForumTopicPollId);

                entity.HasOne(d => d.ForumTopicPoll)
                    .WithMany(p => p.ForumTopicPollLog)
                    .HasForeignKey(d => d.ForumTopicPollId);
            });

            modelBuilder.Entity<ForumTopicPollOption>(entity =>
            {
                entity.HasIndex(e => e.ForumTopicPollId);

                entity.HasOne(d => d.ForumTopicPoll)
                    .WithMany(p => p.ForumTopicPollOption)
                    .HasForeignKey(d => d.ForumTopicPollId);
            });

            modelBuilder.Entity<ForumTopicPollVote>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ForumTopicPollOptionId });

                entity.HasIndex(e => e.ForumTopicPollOptionId);

                entity.HasOne(d => d.ForumTopicPollOption)
                    .WithMany(p => p.ForumTopicPollVote)
                    .HasForeignKey(d => d.ForumTopicPollOptionId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumTopicPollVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ForumTopicReport>(entity =>
            {
                entity.HasIndex(e => e.ForumTopicId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.ZappedUserId);

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumTopicReport)
                    .HasForeignKey(d => d.ForumTopicId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumTopicReportUser)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.ZappedUser)
                    .WithMany(p => p.ForumTopicReportZappedUser)
                    .HasForeignKey(d => d.ZappedUserId);
            });

            modelBuilder.Entity<ForumTopicView>(entity =>
            {
                entity.HasIndex(e => e.ForumTopicId);

                entity.HasIndex(e => new { e.ForumTopicId, e.ViewCount, e.DayDate })
                    .HasName("UIX-DayDate-20170702-150436");

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumTopicView)
                    .HasForeignKey(d => d.ForumTopicId);
            });

            modelBuilder.Entity<ForumTopicVote>(entity =>
            {
                entity.HasKey(e => new { e.ForumTopicId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.ForumTopic)
                    .WithMany(p => p.ForumTopicVote)
                    .HasForeignKey(d => d.ForumTopicId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumTopicVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Ipblock>(entity =>
            {
                entity.ToTable("IPBlock");

                entity.Property(e => e.IpblockId).HasColumnName("IPBlockId");

                entity.Property(e => e.EndIp).HasColumnName("EndIP");

                entity.Property(e => e.StartIp).HasColumnName("StartIP");
            });

            modelBuilder.Entity<Moderator>(entity =>
            {
                entity.Property(e => e.ModeratorId).ValueGeneratedNever();

                entity.HasOne(d => d.ModeratorNavigation)
                    .WithOne(p => p.Moderator)
                    .HasForeignKey<Moderator>(d => d.ModeratorId);
            });

            modelBuilder.Entity<NameMapper>(entity =>
            {
                entity.HasKey(e => e.VideoCategoryId);

                entity.Property(e => e.VideoCategoryId).ValueGeneratedNever();

                entity.HasOne(d => d.VideoCategory)
                    .WithOne(p => p.NameMapper)
                    .HasForeignKey<NameMapper>(d => d.VideoCategoryId);
            });

            modelBuilder.Entity<NameOriginJuncName>(entity =>
            {
                entity.HasKey(e => new { e.NameId, e.NameOriginId });

                entity.HasIndex(e => e.NameOriginId);

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.NameOriginJuncName)
                    .HasForeignKey(d => d.NameId);

                entity.HasOne(d => d.NameOrigin)
                    .WithMany(p => p.NameOriginJuncName)
                    .HasForeignKey(d => d.NameOriginId);
            });

            modelBuilder.Entity<NameView>(entity =>
            {
                entity.HasIndex(e => e.NameId);

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.NameView)
                    .HasForeignKey(d => d.NameId);
            });

            modelBuilder.Entity<NameVote>(entity =>
            {
                entity.HasIndex(e => e.NameId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.NameVote)
                    .HasForeignKey(d => d.NameId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NameVote)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NewsMapper>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.HasIndex(e => e.NewsId);

                entity.Property(e => e.NewsId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170415");

                entity.HasIndex(e => e.DestinationUserId);

                entity.HasIndex(e => e.Seen)
                    .HasName("UIX-seen-20170415");

                entity.HasIndex(e => e.SourceUserId);

                entity.HasIndex(e => new { e.Seen, e.DestinationUserId })
                    .HasName("ras_Notification_DestinationUserId");

                entity.HasOne(d => d.DestinationUser)
                    .WithMany(p => p.NotificationDestinationUser)
                    .HasForeignKey(d => d.DestinationUserId);

                entity.HasOne(d => d.SourceUser)
                    .WithMany(p => p.NotificationSourceUser)
                    .HasForeignKey(d => d.SourceUserId);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasIndex(e => e.ApplicationRoleId);

                entity.HasOne(d => d.ApplicationRole)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.ApplicationRoleId);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasIndex(e => e.CreatedOn)
                    .HasName("UIX_Photo_FilteredCreatedOn")
                    .HasFilter("([Deleted]=(0) AND [PhotoStatus]=(1))");

                entity.HasIndex(e => e.LikeCount);

                entity.HasIndex(e => e.PhotoGalleryId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.ViewCount);

                entity.HasIndex(e => new { e.Deleted, e.PhotoStatus })
                    .HasName("ras_Photo_Deleted");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.PhotoGallery)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.PhotoGalleryId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhotoCategory>(entity =>
            {
                entity.HasIndex(e => e.ParentCategoryId);

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId);
            });

            modelBuilder.Entity<PhotoComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.HasIndex(e => e.ParentCommentId);

                entity.HasIndex(e => e.TargetId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.ParentCommentId, e.Deleted, e.Approved })
                    .HasName("ras_PhotoComment_Deleted");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.ParentComment)
                    .WithMany(p => p.InverseParentComment)
                    .HasForeignKey(d => d.ParentCommentId);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.PhotoComment)
                    .HasForeignKey(d => d.TargetId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoComment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhotoCommentMapper>(entity =>
            {
                entity.HasKey(e => e.PhotoCommentId);

                entity.Property(e => e.PhotoCommentId).ValueGeneratedNever();

                entity.HasOne(d => d.PhotoComment)
                    .WithOne(p => p.PhotoCommentMapper)
                    .HasForeignKey<PhotoCommentMapper>(d => d.PhotoCommentId);
            });

            modelBuilder.Entity<PhotoCommentVote>(entity =>
            {
                entity.HasKey(e => e.CommentVoteId);

                entity.HasIndex(e => e.CommentId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.PhotoCommentVote)
                    .HasForeignKey(d => d.CommentId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoCommentVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<PhotoCompetition>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoCompetition)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<PhotoCompetitionAward>(entity =>
            {
                entity.HasIndex(e => e.PhotoCompetitionId);

                entity.HasOne(d => d.PhotoCompetition)
                    .WithMany(p => p.PhotoCompetitionAward)
                    .HasForeignKey(d => d.PhotoCompetitionId);
            });

            modelBuilder.Entity<PhotoCompetitionMapper>(entity =>
            {
                entity.HasKey(e => e.PhotoCompetitionId);

                entity.Property(e => e.PhotoCompetitionId).ValueGeneratedNever();

                entity.HasOne(d => d.PhotoCompetition)
                    .WithOne(p => p.PhotoCompetitionMapper)
                    .HasForeignKey<PhotoCompetitionMapper>(d => d.PhotoCompetitionId);
            });

            modelBuilder.Entity<PhotoCompetitionPhoto>(entity =>
            {
                entity.HasIndex(e => e.PhotoCompetitionId);

                entity.HasIndex(e => e.PhotoId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.CreatedOn, e.PhotoId, e.ScoreCount, e.PhotoCompetitionId })
                    .HasName("ras_PhotoCompetitionPhoto_PhotoCompetitionId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.PhotoCompetition)
                    .WithMany(p => p.PhotoCompetitionPhoto)
                    .HasForeignKey(d => d.PhotoCompetitionId);

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoCompetitionPhoto)
                    .HasForeignKey(d => d.PhotoId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoCompetitionPhoto)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhotoCompetitionScore>(entity =>
            {
                entity.HasIndex(e => e.PhotoCompetitionPhotoId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.PhotoCompetitionPhoto)
                    .WithMany(p => p.PhotoCompetitionScore)
                    .HasForeignKey(d => d.PhotoCompetitionPhotoId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoCompetitionScore)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhotoCompetitionTag>(entity =>
            {
                entity.HasKey(e => new { e.PhotoCompetitionId, e.PhotoTagId });

                entity.HasIndex(e => e.PhotoTagId);

                entity.HasOne(d => d.PhotoCompetition)
                    .WithMany(p => p.PhotoCompetitionTag)
                    .HasForeignKey(d => d.PhotoCompetitionId);

                entity.HasOne(d => d.PhotoTag)
                    .WithMany(p => p.PhotoCompetitionTag)
                    .HasForeignKey(d => d.PhotoTagId);
            });

            modelBuilder.Entity<PhotoFavorite>(entity =>
            {
                entity.HasIndex(e => e.PhotoId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoFavorite)
                    .HasForeignKey(d => d.PhotoId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoFavorite)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhotoGallery>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoGallery)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhotoJuncCategory>(entity =>
            {
                entity.HasKey(e => new { e.PhotoId, e.PhotoCategoryId });

                entity.HasIndex(e => e.PhotoCategoryId);

                entity.HasOne(d => d.PhotoCategory)
                    .WithMany(p => p.PhotoJuncCategory)
                    .HasForeignKey(d => d.PhotoCategoryId);

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoJuncCategory)
                    .HasForeignKey(d => d.PhotoId);
            });

            modelBuilder.Entity<PhotoJuncTag>(entity =>
            {
                entity.HasKey(e => new { e.PhotoId, e.PhotoTagId });

                entity.HasIndex(e => e.PhotoTagId);

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoJuncTag)
                    .HasForeignKey(d => d.PhotoId);

                entity.HasOne(d => d.PhotoTag)
                    .WithMany(p => p.PhotoJuncTag)
                    .HasForeignKey(d => d.PhotoTagId);
            });

            modelBuilder.Entity<PhotoLog>(entity =>
            {
                entity.HasIndex(e => e.PhotoId);

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoLog)
                    .HasForeignKey(d => d.PhotoId);
            });

            modelBuilder.Entity<PhotoMapper>(entity =>
            {
                entity.HasKey(e => e.PhotoId);

                entity.HasIndex(e => e.OldPhotoId)
                    .HasName("ras_PhotoMapper_OldPhotoId");

                entity.Property(e => e.PhotoId).ValueGeneratedNever();

                entity.HasOne(d => d.Photo)
                    .WithOne(p => p.PhotoMapper)
                    .HasForeignKey<PhotoMapper>(d => d.PhotoId);
            });

            modelBuilder.Entity<PhotoReport>(entity =>
            {
                entity.HasIndex(e => e.PhotoId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoReport)
                    .HasForeignKey(d => d.PhotoId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoReport)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhotoTagMapper>(entity =>
            {
                entity.HasKey(e => e.PhotoTagId);

                entity.Property(e => e.PhotoTagId).ValueGeneratedNever();

                entity.HasOne(d => d.PhotoTag)
                    .WithOne(p => p.PhotoTagMapper)
                    .HasForeignKey<PhotoTagMapper>(d => d.PhotoTagId);
            });

            modelBuilder.Entity<PhotoView>(entity =>
            {
                entity.HasIndex(e => e.PhotoId);

                entity.HasIndex(e => new { e.PhotoId, e.ViewCount, e.DayDate })
                    .HasName("ras_PhotoView_DayDate");

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoView)
                    .HasForeignKey(d => d.PhotoId);
            });

            modelBuilder.Entity<PhotoVote>(entity =>
            {
                entity.HasIndex(e => e.PhotoId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoVote)
                    .HasForeignKey(d => d.PhotoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PhotoVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasIndex(e => e.CountryId);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Province)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<SlideShow>(entity =>
            {
                entity.HasIndex(e => new { e.Link, e.Path, e.CreatedOn, e.Description, e.Deleted, e.DisplayOrder })
                    .HasName("UIX-20170418");

                entity.Property(e => e.Description).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Link).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Path).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<Timeline>(entity =>
            {
                entity.HasIndex(e => e.Deleted)
                    .HasName("UIX-Deleted-20170418");

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.Id, e.DigitTitle, e.Title, e.Deleted, e.Published, e.TimelineType, e.DisplayOrder })
                    .HasName("UIX-IdDigitTitle-20170418");

                entity.Property(e => e.TimelineType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Timeline)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TimelineComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.HasIndex(e => e.ParentCommentId);

                entity.HasIndex(e => e.TargetId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.Approved, e.Deleted, e.ParentCommentId, e.TargetId })
                    .HasName("ras_TimelineComment_Approved");

                entity.HasOne(d => d.ParentComment)
                    .WithMany(p => p.InverseParentComment)
                    .HasForeignKey(d => d.ParentCommentId);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.TimelineComment)
                    .HasForeignKey(d => d.TargetId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TimelineComment)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TimelineCommentVote>(entity =>
            {
                entity.HasKey(e => e.CommentVoteId);

                entity.HasIndex(e => e.CommentId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.TimelineCommentVote)
                    .HasForeignKey(d => d.CommentId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TimelineCommentVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserChild>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserChild)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserEmbryo>(entity =>
            {
                entity.HasIndex(e => e.PregnancyTickerId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.Deleted, e.DisplayPregnancyTicker })
                    .HasName("NonClusteredIndex-20170425-181855");

                entity.HasIndex(e => new { e.Deleted, e.DisplayPregnancyTicker, e.UserId })
                    .HasName("NonClusteredIndex-20170425-181815");

                entity.HasIndex(e => new { e.BirthDate, e.PregnancyTickerId, e.Deleted, e.DisplayPregnancyTicker, e.UserId })
                    .HasName("NonClusteredIndex-20170504-073917");

                entity.HasOne(d => d.PregnancyTicker)
                    .WithMany(p => p.UserEmbryo)
                    .HasForeignKey(d => d.PregnancyTickerId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEmbryo)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserLoginHistory>(entity =>
            {
                entity.HasIndex(e => e.CreatedOn)
                    .HasName("ras_UserLoginHistory_CreatedOn");

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLoginHistory)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserMapper>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.OldUserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserMapper)
                    .HasForeignKey<UserMapper>(d => d.UserId);
            });

            modelBuilder.Entity<UserPicture>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.Deleted, e.IsConfirmed })
                    .HasName("ras_UserPicture_Deleted");

                entity.HasIndex(e => new { e.Deleted, e.IsConfirmed, e.CreatedOn, e.UserId })
                    .HasName("ras_UserPicture_Deleted_IsConfirmed");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPicture)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => e.ProvinceId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.CityId);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.ProvinceId);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserProfile)
                    .HasForeignKey<UserProfile>(d => d.UserId);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.Deleted, e.ProcessStatus, e.VideoStatus })
                    .HasName("UIXF-CreatDeletProcessVideo-20170418")
                    .HasFilter("([Deleted]=(0) AND [ProcessStatus]=(1) AND [VideoStatus]=(1))");

                entity.Property(e => e.ProcessStep).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<VideoCategory>(entity =>
            {
                entity.HasIndex(e => e.ParentCategoryId);

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId);
            });

            modelBuilder.Entity<VideoCategoryMapper>(entity =>
            {
                entity.HasKey(e => e.VideoCategoryId);

                entity.Property(e => e.VideoCategoryId).ValueGeneratedNever();

                entity.HasOne(d => d.VideoCategory)
                    .WithOne(p => p.VideoCategoryMapper)
                    .HasForeignKey<VideoCategoryMapper>(d => d.VideoCategoryId);
            });

            modelBuilder.Entity<VideoComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.HasIndex(e => e.ParentCommentId);

                entity.HasIndex(e => e.TargetId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.ParentComment)
                    .WithMany(p => p.InverseParentComment)
                    .HasForeignKey(d => d.ParentCommentId);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.VideoComment)
                    .HasForeignKey(d => d.TargetId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoComment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VideoCommentMapper>(entity =>
            {
                entity.HasKey(e => e.VideoCommentId);

                entity.Property(e => e.VideoCommentId).ValueGeneratedNever();

                entity.HasOne(d => d.VideoComment)
                    .WithOne(p => p.VideoCommentMapper)
                    .HasForeignKey<VideoCommentMapper>(d => d.VideoCommentId);
            });

            modelBuilder.Entity<VideoCommentVote>(entity =>
            {
                entity.HasKey(e => e.CommentVoteId);

                entity.HasIndex(e => e.CommentId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.VideoCommentVote)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoCommentVote)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<VideoFavorite>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.VideoId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoFavorite)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoFavorite)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VideoLog>(entity =>
            {
                entity.HasIndex(e => e.VideoId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoLog)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<VideoMapper>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.Property(e => e.VideoId).ValueGeneratedNever();

                entity.HasOne(d => d.Video)
                    .WithOne(p => p.VideoMapper)
                    .HasForeignKey<VideoMapper>(d => d.VideoId);
            });

            modelBuilder.Entity<VideoPlay>(entity =>
            {
                entity.HasIndex(e => e.VideoId);

                entity.Property(e => e.PlayCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoPlay)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<VideoQuality>(entity =>
            {
                entity.HasIndex(e => e.VideoId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoQuality)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<VideoReport>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.VideoId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoReport)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoReport)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VideoVideoCategory>(entity =>
            {
                entity.HasKey(e => new { e.VideoId, e.VideoCategoryId });

                entity.HasIndex(e => e.VideoCategoryId);

                entity.HasOne(d => d.VideoCategory)
                    .WithMany(p => p.VideoVideoCategory)
                    .HasForeignKey(d => d.VideoCategoryId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoVideoCategory)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<VideoVideoTag>(entity =>
            {
                entity.HasKey(e => new { e.VideoId, e.VideoTagId });

                entity.HasIndex(e => e.VideoTagId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoVideoTag)
                    .HasForeignKey(d => d.VideoId);

                entity.HasOne(d => d.VideoTag)
                    .WithMany(p => p.VideoVideoTag)
                    .HasForeignKey(d => d.VideoTagId);
            });

            modelBuilder.Entity<VideoView>(entity =>
            {
                entity.HasIndex(e => e.VideoId);

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoView)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<VideoVote>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.VideoId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoVote)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoVote)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.HasSequence("CountBy1")
                .StartsAt(1000)
                .IncrementsBy(5);

            modelBuilder.HasSequence("SequenceTest")
                .StartsAt(5000)
                .IncrementsBy(2);
        }
    }
}
