using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProcommITDD.Library.Model.DTOs
{
    public partial class QuestionDTO
    {

        public int QuestionId { get; set; }

        public int TopicId { get; set; }

        public int CorrectAnswer { get; set; }

        public bool AllowUpload { get; set; }

        public bool AllowNotApplicable { get; set; }

        public bool ShowEstimation { get; set; }

        public bool ShowTemplate { get; set; }

        public string TemplateFileName { get; set; }

        public string TemplateSystemFileName { get; set; }

        public string Text { get; set; }

        public bool Answered { get; set; }
    }
}
