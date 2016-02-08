using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class ProjectStatusDTO
    {
        public int ProjectId { get; set; }

        public List<TopicStatusDTO> Topics { get; set; }

        public List<InformantStatusDTO> Informants { get; set; }

        public List<InformationRequestDTO> InformationRequests { get; set; }

        public List<ChartDataDTO> ChartData { get; set; }

        public int NumberOfQuestions { get; set; }

        public int NumberOfAnswers { get; set; }

        public string Progress { get; set; }
    }
}