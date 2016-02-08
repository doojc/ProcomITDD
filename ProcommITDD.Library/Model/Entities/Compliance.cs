using System.Collections.Generic;

namespace ProcommITDD.Library.Model.Entities
{
    public partial class Compliance
    {
        public Compliance()
        {
            Projects = new HashSet<Project>();
        }

        public int ComplianceId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}