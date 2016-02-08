namespace ProcommITDD.Library.Model.DTOs
{
    public class InformantDTO
    {

        public int InformantID { get; set; }

        public string InformantName { get; set; }

        public bool Selected { get; set; }

        public string TopicsName { get; set; }

        public string TotalQuestions { get; set; }

        public string mailLink { get; set; }

        public bool IsInformantAssigned { get; set; }
    }
}