using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using ProcommITDD.Library.Repository.EF.Interfaces;
using Procomm.DdPlatform.Repository;
using ProcommITDD.Library.Services.Interfaces;
using ProcommITDD.Library.Services.Implementation;
using Unity.WebApi;
using System.Web.Http;
using ProcommITDD.Library.Infrastructure.Logging;

namespace ProcommITDD.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProjectRepository, ProjectRepository>();
            container.RegisterType<IProjectService, ProjectService>();
            container.RegisterType<ILogger, NLogAdapter>();
            
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}