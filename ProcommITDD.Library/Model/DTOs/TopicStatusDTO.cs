using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class TopicStatusDTO
    {
        public int TopicId { get; set; }

        public string TopicName { get; set; }

        public int TotalQuestion { get; set; }

        public int AnsweredQuestions { get; set; }

        public string Progress { get; set; }
    }
}