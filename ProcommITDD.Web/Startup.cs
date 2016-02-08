using AutoMapper;
using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Owin;
using ProcommITDD.Library.Model.Entities;
using ProcommITDD.Library.Services.ViewModels;

[assembly: OwinStartupAttribute(typeof(ProcommITDD.Web.Startup))]
namespace ProcommITDD.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            Mapper.Initialize(config =>
            {
                config.CreateMap<Project, ProjectSummaryView>().ReverseMap();
            });
        }
    }
}
