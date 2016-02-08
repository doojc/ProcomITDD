using System.ComponentModel.DataAnnotations;

namespace ProcommITDD.Library.Model.Entities
{
    public partial class Informant
    {
        public int InformantId { get; set; }

        [Required]
        [StringLength(400)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(400)]
        public string Surname { get; set; }

        [Required]
        [StringLength(400)]
        public string EMail { get; set; }
    }
}
