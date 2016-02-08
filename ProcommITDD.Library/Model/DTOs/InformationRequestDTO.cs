using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class InformationRequestDTO
    {
        public string InformantName { get; set; }

        public List<string> Topics { get; set; }

        public string Deadline { get; set; }

        public string SentOn { get; set; }

        public int NumberOfQuestions { get; set; }

        public int NumberOfAnswers { get; set; }

        public string Progress { get; set; }

        public string LinkToAnswers { get; set; }
    }
}