using Dapper;
using PAS.DBEngine;
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
    public class AuthenticateRepository : IAuthenticateRepository
    {
        ISQLServerHandler _serverHandler;

        public AuthenticateRepository(ISQLServerHandler serverHandler)
        {
            _serverHandler = serverHandler;
        }

        public async Task<int> GetLoginDetailsAsync(LoginDTO login)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@BatchId", login.UserName, DbType.Int64);
                dynamicParameters.Add("@BatchId", login.Password, DbType.Int64);
                 response = await _serverHandler.ExecuteScalarAsync<int>("SaveBatchInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;

        }
    }
}
