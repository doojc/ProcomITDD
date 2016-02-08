using ProcommITDD.Library.Model.Entities;
using ProcommITDD.Library.Repository.EF.Interfaces;
using ProcommITDD.Library.Model.DTOs;
using ProcommITDD.Library.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProcommITDD.Library.Repository.EF;
using AutoMapper;

namespace Procomm.DdPlatform.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private DdPlatformContext _context = new DdPlatformContext();
        //private ILogger<ProjectRepository> _logger;

        public ProjectRepository(DdPlatformContext context)
        {
            _context = context;
            //_logger = logger;
        }

        public ProjectRepository()
        {
            _context = new DdPlatformContext();
        }
                
        public IEnumerable<ProjectSummaryView> GetAll(int userId)
        {
            return Mapper.Map<IEnumerable<ProjectSummaryView>>(_context.Projects.Where(p => p.UserId == userId).ToList());          
        }
    }
}