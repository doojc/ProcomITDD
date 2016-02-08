using ProcommITDD.Library.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class InformantAnswerQuestionDTO
    {
        public int ProjectId { get; set; }

        public int InformantId { get; set; }

        public string TargetCompanyName { get; set; }

        public int GivenAnswersPercent { get; set; }

        public List<TopicDTO> Topics { get; set; }

        public List<QuestionDTO> Questions { get; set; }

        public List<ProjectQuestionDTO> ProjectQuestions { get; set; }
    }
}