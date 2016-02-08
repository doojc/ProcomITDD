using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ProcommITDD.Library.Model.Enumerations;

namespace ProcommITDD.Library.Model.Entities
{
    public partial class Project
    {
        public Project()
        {
            Compliances = new HashSet<Compliance>();
            Questions = new HashSet<Question>();
            ProjectQuestions = new HashSet<ProjectQuestion>();
            Scopes = new HashSet<Scope>();
        }

        public int ProjectId { get; set; }

        public int? PresetId { get; set; }

        public ProjectState State { get; set; }

        public string ProjectName { get; set; }

        public string TargetCompany { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }

        //Priamary contact details
        public string PrimaryContactFirstname { get; set; }

        public string PrimaryContactSurname { get; set; }

        public string PrimaryContactEMail { get; set; }

        public string PrimaryContactStreet { get; set; }

        public string PrimaryContactCity { get; set; }

        public string PrimaryContactZip { get; set; }

        public string PrimaryContactCountry { get; set; }

        public string PrimaryContactMobile { get; set; }

        public string PersonalRemarks { get; set; }

        public int CurrentWizardStep { get; set; }

        public virtual Preset Preset { get; set; }

        public virtual ICollection<Scope> Scopes { get; set; }

        public virtual ICollection<Compliance> Compliances { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public virtual ICollection<ProjectQuestion> ProjectQuestions { get; set; }

        public virtual ICollection<ProjectInformant> ProjectInformants { get; set; }
    }
}
