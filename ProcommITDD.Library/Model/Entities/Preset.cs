using System.Collections.Generic;

namespace ProcommITDD.Library.Model.Entities
{
    public partial class Preset
    {
        public Preset()
        {
            Questions = new HashSet<Question>();
        }

        public int PresetId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
