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

namespace PAS.Repository.Repository
{
    public class LoginRepository : ILoginRepository
    {
        ISQLServerHandler _serverHandler;

        public LoginRepository(ISQLServerHandler serverHandler)
        {
            _serverHandler = serverHandler;
        }

        public async Task<int>  SaveLoginDetailsAsync(LoginDTO login)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@user", login.UserName, DbType.String);
                dynamicParameters.Add("@pass", login.Password, DbType.String);
                response = await _serverHandler.ExecuteScalarAsync<int>("Loginprocedures", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;

        }
    }
}
