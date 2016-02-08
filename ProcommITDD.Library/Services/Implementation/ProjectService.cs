using ProcommITDD.Library.Repository.EF.Interfaces;
using ProcommITDD.Library.Services.Interfaces;
using ProcommITDD.Library.Services.Messaging.ProjectService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcommITDD.Library.Services.Implementation
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public GetProjectsByUserIdResponse GetProjectsByUserId(GetProjectsByUserIdRequest request)
        {
            GetProjectsByUserIdResponse response = new GetProjectsByUserIdResponse();

            response.Projects = _projectRepository.GetAll(request.UserId);

            return response;
        }
    }
}
