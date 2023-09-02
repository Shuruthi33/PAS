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
    public class PrjAllotmentRepository : IPrjAllotmentRepository
    {
        ISQLServerHandler _serverHandler;

        public PrjAllotmentRepository(ISQLServerHandler serverHandler)
        {
            _serverHandler = serverHandler;

        }

        public async Task<int> DeletePrjAllotmentDetailsByIdAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@AllocatedId", Id, DbType.Int16);

                response = await _serverHandler.ExecuteScalarAsync<int>("DeletePrjAllocatedInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }

        public async Task<PrjAllotmentDetailsResultDTO> GetPrjAllotmentDetailsAsync()
        {
            PrjAllotmentDetailsResultDTO prjAllotmentDetails = new PrjAllotmentDetailsResultDTO();
            try
            {
                using (_serverHandler.Connection)
                {
                    prjAllotmentDetails.prjAllotmentDetailsList = (await _serverHandler.QueryAsync<PrjAllotmentDTO>("GetPrjAlloment")).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return prjAllotmentDetails;
        }

        public async Task<PrjAllotmentDTO> GetPrjAllotmentDetailsByIdAsync(int Id)
        {
            PrjAllotmentDTO prjAllotment = new PrjAllotmentDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@AllocatedId", Id, DbType.Int16);

                using (_serverHandler.Connection)
                {
                    prjAllotment = await _serverHandler.QuerySingleAsync<PrjAllotmentDTO>("PrjAllocatedById", dynamicParameters);
                }
            }
            catch (Exception ex)
            {
            }
            return prjAllotment;
        }

        public async Task<int> SavePrjAllotmentDetailsAsync(PrjAllotmentDTO prjAllotment)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@AllocatedId", prjAllotment.AllocatedId, DbType.String);
                dynamicParameters.Add("@UserId", prjAllotment.UserId, DbType.String);
                dynamicParameters.Add("@PrjId", prjAllotment.PrjId, DbType.String);
                dynamicParameters.Add("@MentorId", prjAllotment.MentorId, DbType.String);
                dynamicParameters.Add("@YearId", prjAllotment.YearId, DbType.Int16);
                dynamicParameters.Add("@BathId", prjAllotment.BathId, DbType.String);
                dynamicParameters.Add("@StartDate", prjAllotment.StartDate, DbType.DateTime);
                dynamicParameters.Add("@EndDate", prjAllotment.EndDate, DbType.DateTime);
                dynamicParameters.Add("@StatusId", prjAllotment.StatusId, DbType.String);

                
                response = await _serverHandler.ExecuteScalarAsync<int>("SavePrjAllocatedInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }
    }
}
