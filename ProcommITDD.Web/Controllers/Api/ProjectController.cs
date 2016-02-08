using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProcommITDD.Library.Services.Interfaces;
using ProcommITDD.Library.Services.Messaging.ProjectService;
using ProcommITDD.Library.Services.Implementation;
using ProcommITDD.Library.Repository.EF.Interfaces;
using Procomm.DdPlatform.Repository;
using ProcommITDD.Library.Repository.EF;

namespace ProcommITDD.Web.Controllers.Api
{
    public class ProjectController : ApiController
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET: api/Project      
        public IHttpActionResult Get()
        {
            try
            {
                GetProjectsByUserIdRequest request = new GetProjectsByUserIdRequest();
                request.UserId = 1;
                GetProjectsByUserIdResponse response = _projectService.GetProjectsByUserId(request);
                return Ok(response.Projects);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Project/5
        public string Get(int id)
        {
            return null;
        }

        // POST: api/Project
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Project/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Project/5
        public void Delete(int id)
        {
        }
    }
}
