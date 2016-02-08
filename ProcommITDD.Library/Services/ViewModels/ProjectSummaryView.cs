using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcommITDD.Library.Services.ViewModels
{
    public class ProjectSummaryView
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string State { get; set; }
        public string Completion { get; set; }
    }
}
