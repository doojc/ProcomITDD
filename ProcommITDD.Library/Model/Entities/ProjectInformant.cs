using System;
using System.Collections.Generic;
using ProcommITDD.Library.Model.Enumerations;

namespace ProcommITDD.Library.Model.Entities
{
    public class ProjectInformant
    {
        public ProjectInformant()
        {
            ProjectQuestions = new HashSet<ProjectQuestion>();
        }

        public int ProjectInformantId { get; set; }

        public int ProjectId { get; set; }

        public int InformantId { get; set; }

        public InfoRequestState State { get; set; }

        public DateTime? Deadline { get; set; }

        public DateTime DateCreated { get; set; }

        public Guid AccessCode { get; set; }

        public virtual Project Project { get; set; }

        public virtual Informant Informant { get; set; }

        public virtual ICollection<ProjectQuestion> ProjectQuestions { get; set; }
    }
}