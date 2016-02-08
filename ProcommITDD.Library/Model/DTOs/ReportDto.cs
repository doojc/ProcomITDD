using System.Collections.Generic;
using ProcommITDD.Library.Model.Enumerations;

namespace ProcommITDD.Library.Model.DTOs
{
    public class ReportDto
    {
        public int SummaryScoreGreen { get; set; }
        public int SummaryScoreYellow { get; set; }
        public int SummaryScoreRed { get; set; }

        public List<ReportTopicScoreDto> TopicScores { get; set; }

        public int OperationalRiskTotal { get; set; }
        public int MonetaryRiskTotal { get; set; }
        public int DependencyRiskTotal { get; set; }
    }


}