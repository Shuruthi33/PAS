using Microsoft.Extensions.Configuration;
/***********************************************************************************************************
    * Created by       : Shuruthi
    * Created On       : 28 Aug 2023
    *
    * Reviewed By      :
    * Reviewed On      :
    *
    * Purpose          : To have Data base optionnal methods that handles insert, update, delete and get and get all stored procedures data
    ***********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace PAS.DBEngine
{
   public interface ISQLServerHandler
    {
        IDbConnection Connection { get; }

        Task ExecuteNonQueryAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure); // Insert, Update and Delete
        Task<T> ExecuteScalarAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure);  // return the object values
        Task<T> QuerySingleAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure); // return the Data table values
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object parameters = null, CommandType commandType = CommandType.StoredProcedure);   // return the Single data table
        Task<GridReader> QueryMultipleAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure);  // return the Data Set  values

    }

    public class SQLServerHandler : ISQLServerHandler
    {
        private readonly IConfiguration _configuration;
        public SQLServerHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Connection
        {
            get
            {
                var sqlconnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                return sqlconnection;
            }
        }

        public async Task ExecuteNonQueryAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {

            using (Connection)
            {
                await Connection.ExecuteAsync(sql, parameters, commandType: commandType);
            }
        }

        public async Task<T> ExecuteScalarAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (Connection)
            {
                return await Connection.ExecuteScalarAsync<T>(sql, parameters, commandType: commandType);
            }
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (Connection)
            {
                return await Connection.QueryAsync<T>(sql, parameters, commandType: commandType, commandTimeout: 600);
            }
        }

        public async Task<GridReader> QueryMultipleAsync(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            return await Connection.QueryMultipleAsync(sql, parameters, commandType: commandType, commandTimeout: 180);
        }

        public async Task<T> QuerySingleAsync<T>(string sql, object? parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (Connection)
            {
                return await Connection.QuerySingleAsync<T>(sql, parameters, commandType: commandType);
            }
        }
    }
}
