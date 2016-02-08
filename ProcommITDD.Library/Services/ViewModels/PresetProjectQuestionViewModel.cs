using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Services.ViewModels
{
    public class PresetProjectQuestionViewModel
    {
        //public int TopicID { get; set; }

        public string TopicName { get; set; }

        public int ProjectID { get; set; }

        public int ProjectQuestionID { get; set; }

        public string QuestionText { get; set; }

        public bool IncludedInProject { get; set; }
    }
}