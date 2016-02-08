using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Services.ViewModels
{
    public class InfoRequestViewModel
    {
        public int InformantID { get; set; } 

        public int ProjectInformantID { get; set; }

        public bool ShowAnswerButton { get; set; }        
    }
}