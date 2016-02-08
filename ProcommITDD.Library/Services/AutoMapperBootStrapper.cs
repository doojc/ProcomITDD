using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProcommITDD.Library.Model.Entities;
using ProcommITDD.Library.Services.ViewModels;

namespace ProcommITDD.Library.Services
{
    public class AutoMapperBootStrapper
    {
        public static void ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectSummaryView>());
            var mapper = config.CreateMapper();
            //ProjectSummaryView projects = mapper.Map<ProjectSummaryView>(Project);
        }
    }
}
