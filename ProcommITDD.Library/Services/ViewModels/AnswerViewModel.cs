using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Services.ViewModels
{
    public class AnswerViewModel
    {

        public int AnswerID { get; set; }

        public int UserID { get; set; }

        public string QuestionText { get; set; }

        public string TopicName { get; set; }

        public int ProjectQuestionID { get; set; }

        public int AnswerYesNo { get; set; }

        public string AnswerYesNoText { get; set; }

        public double EstimatedEffortInHours { get; set; }

        public string FileName { get; set; }

        public string SystemFileName { get; set; }

        public string TemplateFileName { get; set; }

        public string TemplateSystemFileName { get; set; }

        public int CorrectAnswer { get; set; }

        public string Remark { get; set; }

    }
}