using ProcommITDD.Library.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class ProjectPresetQuestionDTO
    {
        public bool isDisabled { get; set; }
        public List<ProjectPresetQuestionViewModel> ProjectPresetQuestions { get; set; }
    }
}