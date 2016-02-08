using System.ComponentModel.DataAnnotations;

namespace ProcommITDD.Library.Model.Entities
{
    public partial class Answer
    {
        public int UserId { get; set; }

        public int AnswerYesNo { get; set; }

        public double EstimatedEffortInHours { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string SystemFileName { get; set; }

        [Key]
        public int ProjectQuestionId { get; set; }

        [StringLength(4000)]
        public string Remark { get; set; }

        public virtual ProjectQuestion ProjectQuestion { get; set; }
    }
}
