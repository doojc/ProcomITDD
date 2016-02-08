using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.Entities
{
    public partial class ProjectQuestion
    {
        [Key]
        public int ProjectQuestionId { get; set; }

        public string TopicName { get; set; }

        public int TopicOrderNum { get; set; }

        public short OperationalWeight { get; set; }

        public short MonetaryWeight { get; set; }

        public short DependencyWeight { get; set; }

        public int CorrectAnswer { get; set; }

        public bool AllowUpload { get; set; }

        public bool AllowNotApplicable { get; set; }

        public bool ShowEstimation { get; set; }

        public bool ShowTemplate { get; set; }

        [StringLength(200)]
        public string TemplateFileName { get; set; }

        [StringLength(50)]
        public string TemplateSystemFileName { get; set; }

        public int OrderNum { get; set; }

        public int QuestionNum { get; set; }

        //[Required]
        public string Text { get; set; }

        public short Type { get; set; }

        public string Notes { get; set; }

        //public virtual Topic Topic { get; set; }

        public int? AnswerId { get; set; }

        public virtual Answer Answer { get; set; }

        //public virtual ICollection<Project> Projects { get; set; }

        public int? ProjectId { get; set; }

        public Project Project { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public int? ProjectInformantId { get; set; }

        public ProjectInformant ProjectInformant { get; set; }
    }
}