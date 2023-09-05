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
    public  class YearRepository : IYearRepository
    {
        ISQLServerHandler _serverHandler;

        public YearRepository(ISQLServerHandler serverHandler)
        {
            _serverHandler = serverHandler;
        }

        public async Task<int> DeleteYearDetailsByIdAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@YearId", Id, DbType.Int16);

                response = await _serverHandler.ExecuteScalarAsync<int>("DeleteYearInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }

        public async Task<YearDetailsResultDTO> GetYearDetailsAsync()
        {
            YearDetailsResultDTO yearDetailResult = new YearDetailsResultDTO();
            try
            {
                using (_serverHandler.Connection)
                {
                    yearDetailResult.yearDetailsList = (await _serverHandler.QueryAsync<YearDTO>("GetYearInfo")).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return yearDetailResult;
        }

        public async Task<YearDTO> GetYearDetailsByIdAsync(int Id)
        {
            YearDTO userDetail = new YearDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@YearId", Id, DbType.Int16);

                using (_serverHandler.Connection)
                {
                    userDetail = await _serverHandler.QuerySingleAsync<YearDTO>("GetYearById", dynamicParameters);
                }
            }
            catch (Exception ex)
            {
            }
            return userDetail;
        }

        public async Task<int> SaveYearDetailsAsync(YearDTO year)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@YearId", year.YearId, DbType.Int64);
                dynamicParameters.Add("@YearName", year.YearName, DbType.String);
               


                response = await _serverHandler.ExecuteScalarAsync<int>("SaveYearInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }
    }
}
