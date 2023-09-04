using Dapper;
using PAS.DBEngine;
using PAS.Model.Input;
using PAS.Model.Output;
using PAS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Implementation
{
    public class ProjectRepository : IProjectRepository
    {
        ISQLServerHandler _serverHandler;

        public ProjectRepository(ISQLServerHandler serverHandler)
        {
            _serverHandler = serverHandler;
        }

        public async Task<int> DeleteProjectAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@PrjId", Id, DbType.Int16);

                response = await _serverHandler.ExecuteScalarAsync<int>("DeletePrjInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }

        public async Task<ProjectDetailsResultDTO> GetProjectAsync()
        {
            ProjectDetailsResultDTO projrctDetailResult = new ProjectDetailsResultDTO();
            try
            {
                using (_serverHandler.Connection)
                {
                    projrctDetailResult.projectDetailsList = (await _serverHandler.QueryAsync<ProjectDTO>("GetPrjInfo")).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return projrctDetailResult;
        }

        public async Task<ProjectDTO> GetProjectByIdAsync(int Id)
        {
            ProjectDTO projectDetail = new ProjectDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@PrjId", Id, DbType.Int16);

                using (_serverHandler.Connection)
                {
                    projectDetail = await _serverHandler.QuerySingleAsync<ProjectDTO>("GetPrjById", dynamicParameters);
                }
            }
            catch (Exception ex)
            {
            }
            return projectDetail;
        }

       

        public async Task<int> SaveProjectAsync(ProjectDTO project)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@PrjId", project.PrjId, DbType.String);
                dynamicParameters.Add("@PrjTitle", project.PrjTitle, DbType.String);
                dynamicParameters.Add("@PrjScope", project.PrjScope, DbType.String);
                dynamicParameters.Add("@PrjFuture", project.PrjFuture, DbType.String);
                dynamicParameters.Add("@PrjAnnouncement", project.PrjAnnouncement, DbType.String);
                response = await _serverHandler.ExecuteScalarAsync<int>("SaveProjectInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }
    }
}
