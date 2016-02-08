using ProcommITDD.Library.Model.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProcommITDD.Library.Model.DTOs
{
    public partial class ProjectQuestionDTO
    {
        public int ProjectQuestionId { get; set; }

        public int? ProjectId { get; set; }

        public int QuestionId { get; set; }

        public string TopicName { get; set; }

        public int TopicOrderNum { get; set; }

        public int CorrectAnswer { get; set; }

        public bool AllowUpload { get; set; }

        public bool AllowNotApplicable { get; set; }

        public bool ShowEstimation { get; set; }

        //public Question.TemplateOption ShowTemplate { get; set; }

        public string TemplateFileName { get; set; }

        public string TemplateSystemFileName { get; set; }

        public string Text { get; set; }

        public bool Answered { get; set; }

        public bool isRemarkSet { get; set; }

        public string RemarkText{ get; set; }

        public AnswerDTO Answer { get; set; }
    }
}
