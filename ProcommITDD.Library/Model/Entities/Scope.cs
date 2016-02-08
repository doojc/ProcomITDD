using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProcommITDD.Library.Model.Entities
{
    public partial class Scope
    {
        public Scope()
        {
            Projects = new HashSet<Project>();
        }
        public int ScopeId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}