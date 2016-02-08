using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class InformantStatusDTO
    {
        public int InformantId { get; set; }

        public string InformantName { get; set; }

        public string Progress { get; set; }

        public string TotalProgress { get; set; }

        public int NumberOfQuestions { get; set; }

        public int NumberOfAnswers { get; set; }

        public string Color { get; set; }
    }
}