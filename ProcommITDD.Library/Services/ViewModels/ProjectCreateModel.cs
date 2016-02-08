using ProcommITDD.Library.Model.Entities;
using ProcommITDD.Library.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProcommITDD.Library.Services.ViewModels
{
    /// <summary>
    /// Model that is used when Creating of the project occurs
    /// </summary>
    public class ProjectCreateModel
    {
        public string ProjectName { get; set; }
        public int? ProjectID { get; set; }
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
        public string CheckedScopeItems { get; set; }
        public string CheckedComplianceItems { get; set; }
        public string PersonalRemarks { get; set; }
        public int CurrentWizardStep { get; set; }
    }
}