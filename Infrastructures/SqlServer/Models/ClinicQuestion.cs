using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicQuestion
    {
        public ClinicQuestion()
        {
            ClinicQuestionComment = new HashSet<ClinicQuestionComment>();
            ClinicQuestionFavorite = new HashSet<ClinicQuestionFavorite>();
            ClinicQuestionTag = new HashSet<ClinicQuestionTag>();
            ClinicQuestionView = new HashSet<ClinicQuestionView>();
            ClinicQuestionVote = new HashSet<ClinicQuestionVote>();
        }

        public int ClinicQuestionId { get; set; }
        public DateTime? AnsweredOn { get; set; }
        public DateTime? AssignedOn { get; set; }
        public int ClinicCategoryId { get; set; }
        public string ClinicConsultantId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string IpAddress { get; set; }
        public bool IsAnonymous { get; set; }
        public bool? IsConfirmed { get; set; }
        public int QuestionStatus { get; set; }
        public string QuestionerUserId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public int ViewCount { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public int CommentCount { get; set; }
        public int LikeCount { get; set; }

        public ClinicCategory ClinicCategory { get; set; }
        public ClinicConsultant ClinicConsultant { get; set; }
        public AspNetUsers QuestionerUser { get; set; }
        public ClinicConsultantAnswer ClinicConsultantAnswer { get; set; }
        public ClinicQuestionMapper ClinicQuestionMapper { get; set; }
        public ICollection<ClinicQuestionComment> ClinicQuestionComment { get; set; }
        public ICollection<ClinicQuestionFavorite> ClinicQuestionFavorite { get; set; }
        public ICollection<ClinicQuestionTag> ClinicQuestionTag { get; set; }
        public ICollection<ClinicQuestionView> ClinicQuestionView { get; set; }
        public ICollection<ClinicQuestionVote> ClinicQuestionVote { get; set; }
    }
}
