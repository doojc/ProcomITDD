using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class TopicDTO
    {
        public int TopicId { get; set; }

        public string Name { get; set; }

        public int OrderNum { get; set; }

        public int TotalQuestion { get; set; }

        public int AnsweredQuestions { get; set; }
    }
}