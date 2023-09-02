using PAS.Model.Input;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Interface
{
    public interface IProjectRepository
    {
        Task<ProjectDetailsResultDTO> GetProjectAsync();
        Task<ProjectDTO> GetProjectByIdAsync(int Id);
        Task<int> SaveProjectAsync(ProjectDTO project);
        Task<int> DeleteProjectAsync(int Id);
    }
}
