using PAS.Model;
using PAS.Model.Input;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Interface
{
   public interface IProjectService
    {
        Task<ResultDataArgs> GetProjectAsync();
        Task<ResultDataArgs> GetProjectByIdAsync(int Id);
        Task<ResultDataArgs> SaveProjectAsync(ProjectDTO project);
        Task<ResultDataArgs> DeleteProjectAsync(int Id);
        
    }
}
