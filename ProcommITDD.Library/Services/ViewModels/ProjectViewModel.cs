using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProcommITDD.Library.Services.ViewModels
{
    public class ProjectViewModel
    {
        public string ProjectName { get; set; }
        public int ProjectID { get; set; }
        public bool State { get; set; }
        public int UserID { get; set; }
        public string PC_Firstname { get; set; }
        public string PC_Surname { get; set; }
        public string PC_Email { get; set; }
        public string PC_Street { get; set; }
        public string PC_City { get; set; }
        public string PC_ZIP { get; set; }
        public string PC_Country { get; set; }
        public string PC_Mobile { get; set; }
        public Array CheckedScopeItems { get; set; }
        public Array CheckedComplianceItems { get; set; }
        public string PersonalRemarks { get; set; }
        public int CurrentWizardStep { get; set; }
    }
}