using ProcommITDD.Library.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcommITDD.Library.Model.Entities;
using ProcommITDD.Library.Services.ViewModels;

namespace ProcommITDD.Library.Repository.EF.Interfaces
{
    public interface IProjectRepository
    {
        /// <summary>
        /// Get list of all projects
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProjectSummaryView> GetAll(int userId);
    }
}
