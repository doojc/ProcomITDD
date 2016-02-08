using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Services.ViewModels
{
    public class ProjectPresetQuestionViewModel
    {
        public int TopicID { get; set; }

        public string TopicName { get; set; }

        public int ProjectID { get; set; }

        public int QuestionID { get; set; }

        public string QuestionText { get; set; }

        public bool IncludedInProject { get; set; }

        public bool IsDisabled { get; set; }
    }
}