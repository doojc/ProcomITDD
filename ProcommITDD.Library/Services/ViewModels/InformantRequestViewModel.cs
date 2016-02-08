using System;
using ProcommITDD.Library.Model.Enumerations;
using System.Collections.Generic;

namespace ProcommITDD.Library.Services.ViewModels
{
    public class InformantRequestViewModel
    {
        public int ProjectInformantID { get; set; }
        public int UserID { get; set; }
        public int InformantID { get; set; }
        public int ProjectID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TargetCompany { get; set; }
        public DateTime? Deadline { get; set; }
        public InfoRequestState State { get; set; }
        public string AnswerFormUrl { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string InformantName { get; set; }
        public string TopicsName { get; set; }
        public List<string> TopicNames { get; set; }
        public string TotalQuestions { get; set; }
        public string MailLink { get; set; }
        public bool RequestSend { get; set; }
        public bool SendOutClick { get; set; }
        public bool DisableSendOutClick { get; set; }
    }
}