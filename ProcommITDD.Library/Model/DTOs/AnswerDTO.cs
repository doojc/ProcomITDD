namespace ProcommITDD.Library.Model.DTOs
{
    public class AnswerDTO
    {
        public int AnswerID { get; set; }

        public int UserID { get; set; }

        public int QuestionID { get; set; }

        public int ProjectQuestionID { get; set; }

        public int AnswerYesNo { get; set; }

        public double EstimatedEffortInHours { get; set; }

        public string FileName { get; set; }

        public string SystemFileName { get; set; }

        public int CorrectAnswer { get; set; }

        public string Remark { get; set; }
    }
}