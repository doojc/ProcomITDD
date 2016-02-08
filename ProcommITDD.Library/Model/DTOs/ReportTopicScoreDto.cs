using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class ReportTopicScoreDto
    {
        public string Topic { get; set; }
        public int ScoreGreen { get; set; }
        public int ScoreYellow { get; set; }
        public int ScoreRed { get; set; }
        public bool HasRedFlag { get; set; }
    }
}