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
using ProcommITDD.Library.Infrastructure.Logging;

namespace ProcommITDD.Web.Controllers.Api
{
    public class ProjectController : ApiController
    {
        private readonly IProjectService _projectService;
        private readonly ILogger _logger;

        public ProjectController(IProjectService projectService, ILogger logger)
        {
            _projectService = projectService;
            _logger = logger;
        }

        // GET: api/Project      
        public IHttpActionResult Get()
        {
            try
            {
                GetProjectsByUserIdRequest request = new GetProjectsByUserIdRequest();
                request.UserId = 1;

                if (request == null)
                {
                    _logger.Log(String.Format("GetProjectsByUserIdRequest is null. Returning Bad Request."));
                    return BadRequest("GetProjectsByUserIdRequest is null");
                }

                _logger.Log(String.Format("Fetching projects for UserId '{0}'", request.UserId));

                GetProjectsByUserIdResponse response = _projectService.GetProjectsByUserId(request);

                _logger.Log(String.Format("Found {0} projects.", response.Projects.ToArray().Length));

                return Ok(response.Projects);
            }
            catch (Exception ex)
            {
                _logger.Log(String.Format("Failed to get projects: {0}", ex.Message));
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
