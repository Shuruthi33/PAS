using PAS.Model.Output;
using PAS.Model;
using PAS.Serivce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAS.Repository.Interface;
using PAS.Model.Input;

namespace PAS.Serivce.Implementation
{
    public class ProjectService : IProjectService
    {
        IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectDetails)
        {
            _projectRepository = projectDetails;
        }

        public async  Task<ResultDataArgs> DeleteProjectAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _projectRepository.DeleteProjectAsync(Id);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Deleted Successfully";

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultDataArgs> GetProjectAsync()
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            ProjectDetailsResultDTO obj = await _projectRepository.GetProjectAsync();
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.projectDetailsList;

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async  Task<ResultDataArgs> GetProjectByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            ProjectDTO obj = await _projectRepository.GetProjectByIdAsync(Id);
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj;

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultDataArgs> SaveProjectAsync(ProjectDTO project)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _projectRepository.SaveProjectAsync(project);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Save Successfully";
            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }
    }
}
