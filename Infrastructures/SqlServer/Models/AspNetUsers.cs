using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            ApplicationRoleUser = new HashSet<ApplicationRoleUser>();
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            BlogComment = new HashSet<BlogComment>();
            BlogCommentVote = new HashSet<BlogCommentVote>();
            BlogPostAuthorUser = new HashSet<BlogPost>();
            BlogPostCheckoutUser = new HashSet<BlogPost>();
            BlogPostUser = new HashSet<BlogPost>();
            BlogPostVote = new HashSet<BlogPostVote>();
            ClinicConsultantAnswerUseful = new HashSet<ClinicConsultantAnswerUseful>();
            ClinicQuestion = new HashSet<ClinicQuestion>();
            ClinicQuestionComment = new HashSet<ClinicQuestionComment>();
            ClinicQuestionCommentVote = new HashSet<ClinicQuestionCommentVote>();
            ClinicQuestionFavorite = new HashSet<ClinicQuestionFavorite>();
            ClinicQuestionVote = new HashSet<ClinicQuestionVote>();
            ContactAddressee = new HashSet<Contact>();
            ContactRequest = new HashSet<ContactRequest>();
            ContactRequester = new HashSet<Contact>();
            Conversation = new HashSet<Conversation>();
            ConversationMessage = new HashSet<ConversationMessage>();
            ConversationMessageState = new HashSet<ConversationMessageState>();
            ConversationParticipant = new HashSet<ConversationParticipant>();
            ForumPost = new HashSet<ForumPost>();
            ForumPostFavorite = new HashSet<ForumPostFavorite>();
            ForumPostReportUser = new HashSet<ForumPostReport>();
            ForumPostReportZappedUser = new HashSet<ForumPostReport>();
            ForumPostVote = new HashSet<ForumPostVote>();
            ForumTopic = new HashSet<ForumTopic>();
            ForumTopicFavorite = new HashSet<ForumTopicFavorite>();
            ForumTopicManager = new HashSet<ForumTopicManager>();
            ForumTopicMemberCaller = new HashSet<ForumTopicMember>();
            ForumTopicMemberMember = new HashSet<ForumTopicMember>();
            ForumTopicPollVote = new HashSet<ForumTopicPollVote>();
            ForumTopicReportUser = new HashSet<ForumTopicReport>();
            ForumTopicReportZappedUser = new HashSet<ForumTopicReport>();
            ForumTopicVote = new HashSet<ForumTopicVote>();
            NameVote = new HashSet<NameVote>();
            NotificationDestinationUser = new HashSet<Notification>();
            NotificationSourceUser = new HashSet<Notification>();
            Photo = new HashSet<Photo>();
            PhotoComment = new HashSet<PhotoComment>();
            PhotoCommentVote = new HashSet<PhotoCommentVote>();
            PhotoCompetition = new HashSet<PhotoCompetition>();
            PhotoCompetitionPhoto = new HashSet<PhotoCompetitionPhoto>();
            PhotoCompetitionScore = new HashSet<PhotoCompetitionScore>();
            PhotoFavorite = new HashSet<PhotoFavorite>();
            PhotoGallery = new HashSet<PhotoGallery>();
            PhotoReport = new HashSet<PhotoReport>();
            PhotoVote = new HashSet<PhotoVote>();
            Timeline = new HashSet<Timeline>();
            TimelineComment = new HashSet<TimelineComment>();
            TimelineCommentVote = new HashSet<TimelineCommentVote>();
            UserLoginHistory = new HashSet<UserLoginHistory>();
            UserPicture = new HashSet<UserPicture>();
            Video = new HashSet<Video>();
            VideoComment = new HashSet<VideoComment>();
            VideoCommentVote = new HashSet<VideoCommentVote>();
            VideoFavorite = new HashSet<VideoFavorite>();
            VideoReport = new HashSet<VideoReport>();
            VideoVote = new HashSet<VideoVote>();
        }

        public string Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public int ForumPostCount { get; set; }
        public int ForumTopicCount { get; set; }
        public DateTime? LastLoginOn { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string PlainActive { get; set; }
        public bool ProfileCompleted { get; set; }
        public string SecurityStamp { get; set; }
        public bool Suspended { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserName { get; set; }
        public int UserType { get; set; }
        public int VerificationMethod { get; set; }
        public string Avatar { get; set; }
        public string Nickname { get; set; }
        public string Signature { get; set; }
        public string Description { get; set; }

        public ClinicConsultant ClinicConsultant { get; set; }
        public Moderator Moderator { get; set; }
        public UserMapper UserMapper { get; set; }
        public UserProfile UserProfile { get; set; }
        public ICollection<ApplicationRoleUser> ApplicationRoleUser { get; set; }
        public ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public ICollection<BlogComment> BlogComment { get; set; }
        public ICollection<BlogCommentVote> BlogCommentVote { get; set; }
        public ICollection<BlogPost> BlogPostAuthorUser { get; set; }
        public ICollection<BlogPost> BlogPostCheckoutUser { get; set; }
        public ICollection<BlogPost> BlogPostUser { get; set; }
        public ICollection<BlogPostVote> BlogPostVote { get; set; }
        public ICollection<ClinicConsultantAnswerUseful> ClinicConsultantAnswerUseful { get; set; }
        public ICollection<ClinicQuestion> ClinicQuestion { get; set; }
        public ICollection<ClinicQuestionComment> ClinicQuestionComment { get; set; }
        public ICollection<ClinicQuestionCommentVote> ClinicQuestionCommentVote { get; set; }
        public ICollection<ClinicQuestionFavorite> ClinicQuestionFavorite { get; set; }
        public ICollection<ClinicQuestionVote> ClinicQuestionVote { get; set; }
        public ICollection<Contact> ContactAddressee { get; set; }
        public ICollection<ContactRequest> ContactRequest { get; set; }
        public ICollection<Contact> ContactRequester { get; set; }
        public ICollection<Conversation> Conversation { get; set; }
        public ICollection<ConversationMessage> ConversationMessage { get; set; }
        public ICollection<ConversationMessageState> ConversationMessageState { get; set; }
        public ICollection<ConversationParticipant> ConversationParticipant { get; set; }
        public ICollection<ForumPost> ForumPost { get; set; }
        public ICollection<ForumPostFavorite> ForumPostFavorite { get; set; }
        public ICollection<ForumPostReport> ForumPostReportUser { get; set; }
        public ICollection<ForumPostReport> ForumPostReportZappedUser { get; set; }
        public ICollection<ForumPostVote> ForumPostVote { get; set; }
        public ICollection<ForumTopic> ForumTopic { get; set; }
        public ICollection<ForumTopicFavorite> ForumTopicFavorite { get; set; }
        public ICollection<ForumTopicManager> ForumTopicManager { get; set; }
        public ICollection<ForumTopicMember> ForumTopicMemberCaller { get; set; }
        public ICollection<ForumTopicMember> ForumTopicMemberMember { get; set; }
        public ICollection<ForumTopicPollVote> ForumTopicPollVote { get; set; }
        public ICollection<ForumTopicReport> ForumTopicReportUser { get; set; }
        public ICollection<ForumTopicReport> ForumTopicReportZappedUser { get; set; }
        public ICollection<ForumTopicVote> ForumTopicVote { get; set; }
        public ICollection<NameVote> NameVote { get; set; }
        public ICollection<Notification> NotificationDestinationUser { get; set; }
        public ICollection<Notification> NotificationSourceUser { get; set; }
        public ICollection<Photo> Photo { get; set; }
        public ICollection<PhotoComment> PhotoComment { get; set; }
        public ICollection<PhotoCommentVote> PhotoCommentVote { get; set; }
        public ICollection<PhotoCompetition> PhotoCompetition { get; set; }
        public ICollection<PhotoCompetitionPhoto> PhotoCompetitionPhoto { get; set; }
        public ICollection<PhotoCompetitionScore> PhotoCompetitionScore { get; set; }
        public ICollection<PhotoFavorite> PhotoFavorite { get; set; }
        public ICollection<PhotoGallery> PhotoGallery { get; set; }
        public ICollection<PhotoReport> PhotoReport { get; set; }
        public ICollection<PhotoVote> PhotoVote { get; set; }
        public ICollection<Timeline> Timeline { get; set; }
        public ICollection<TimelineComment> TimelineComment { get; set; }
        public ICollection<TimelineCommentVote> TimelineCommentVote { get; set; }
        public ICollection<UserLoginHistory> UserLoginHistory { get; set; }
        public ICollection<UserPicture> UserPicture { get; set; }
        public ICollection<Video> Video { get; set; }
        public ICollection<VideoComment> VideoComment { get; set; }
        public ICollection<VideoCommentVote> VideoCommentVote { get; set; }
        public ICollection<VideoFavorite> VideoFavorite { get; set; }
        public ICollection<VideoReport> VideoReport { get; set; }
        public ICollection<VideoVote> VideoVote { get; set; }
    }
}
