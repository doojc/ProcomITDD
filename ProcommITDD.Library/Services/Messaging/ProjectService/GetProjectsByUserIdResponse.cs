using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcommITDD.Library.Services.ViewModels;

namespace ProcommITDD.Library.Services.Messaging.ProjectService
{
    public class GetProjectsByUserIdResponse
    {
        public int UserId { get; set; }
        public IEnumerable<ProjectSummaryView> Projects { get; set; }
    }
}
