using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProcommITDD.Library.Model.Entities
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            Projects = new HashSet<Project>();
            Presets = new HashSet<Preset>();
            ProjectInformants = new HashSet<ProjectInformant>();
        }

        public int QuestionId { get; set; }

        public int TopicId { get; set; }

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

        public bool IsDeleted { get; set; }

        [Required]
        public string Text { get; set; }

        public short Type { get; set; }

        public string Notes { get; set; }

        public virtual Topic Topic { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<Preset> Presets { get; set; }

        public virtual ICollection<ProjectInformant> ProjectInformants { get; set; }

    }
}
