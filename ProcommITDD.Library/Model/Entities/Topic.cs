namespace ProcommITDD.Library.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Topic
    {
        public Topic()
        {
            Questions = new HashSet<Question>();            
        }

        public int TopicId { get; set; }

        public int OrderNum { get; set; }

        public int TopicNum { get; set; }

        [Required]
        [StringLength(1000)]
        public string Name { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
