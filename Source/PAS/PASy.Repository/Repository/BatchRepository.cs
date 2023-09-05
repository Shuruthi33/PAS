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

namespace PAS.Repository.Repository
{
    public class BatchRepository : IBatchRepository
    {
        ISQLServerHandler _serverHandler;

        public BatchRepository(ISQLServerHandler serverHandler)
        {
            _serverHandler = serverHandler;
        }

        public async Task<int> DeleteBatchDetailsAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@BatchId", Id, DbType.Int16);

                response = await _serverHandler.ExecuteScalarAsync<int>("DeleteBatchInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }

        public async Task<BatchDetailsResultDTO> GetBatchDetailsAsync()
        {
            BatchDetailsResultDTO batchDetailResult = new BatchDetailsResultDTO();
            try
            {
                using (_serverHandler.Connection)
                {
                    batchDetailResult.batchDetailsList = (await _serverHandler.QueryAsync<BatchDTO>("GetBatchInfo")).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return batchDetailResult;

        }

        public async Task<BatchDTO> GetBatchDetailsByIdAsync(int Id)
        {
            BatchDTO batchDetail = new BatchDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@BatchId", Id, DbType.Int16);

                using (_serverHandler.Connection)
                {
                    batchDetail = await _serverHandler.QuerySingleAsync<BatchDTO>("GetBatchById", dynamicParameters);
                }
            }
            catch (Exception ex)
            {
            }
            return batchDetail;
        }

        public async Task<int> SaveBatchDetailsAsync(BatchDTO batch)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@BatchId", batch.BatchId, DbType.Int64);
                dynamicParameters.Add("@BatchName", batch.BatchName, DbType.String);
                dynamicParameters.Add("@YearId", batch.YearId, DbType.Int16);
                dynamicParameters.Add("@StartDate", batch.StartDate, DbType.String);
                dynamicParameters.Add("@EndDate", batch.EndDate, DbType.String);

      
                response = await _serverHandler.ExecuteScalarAsync<int>("SaveBatchInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        

      

        }
    }
}
