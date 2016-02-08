using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcommITDD.Library.Services.Messaging.ProjectService;

namespace ProcommITDD.Library.Services.Interfaces
{
    public interface IProjectService
    {
        GetProjectsByUserIdResponse GetProjectsByUserId(GetProjectsByUserIdRequest request);
    }
}
