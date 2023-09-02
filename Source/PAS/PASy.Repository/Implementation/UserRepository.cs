using Dapper;
using PAS.DBEngine;
using PAS.Model;
using PAS.Model.Input;
using PAS.Model.Output;
using PAS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Implementation
{
  public class UserRepository : IUserRepository
    {
        ISQLServerHandler _serverHandler;

        public UserRepository(ISQLServerHandler serverHandler)
        {
            _serverHandler = serverHandler;
        }

        public async Task<int> DeleteUserDetailsByIdAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@StudentId", Id, DbType.Int16);

                response = await _serverHandler.ExecuteScalarAsync<int>("DeleteUserInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }

        public async Task<UserDetailsResultDTO> GetUserDetailsAsync()
        {
            UserDetailsResultDTO userDetailResult = new UserDetailsResultDTO();
            try
            {
                using (_serverHandler.Connection)
                {
                    userDetailResult.userDetailList = (await _serverHandler.QueryAsync<UserDetailDTO>("GetUserInfo")).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return userDetailResult;
        }

        public async Task<UserDetailDTO> GetUserDetailsByIdAsync(int Id)
        {
            UserDetailDTO userDetail = new UserDetailDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@UserId", Id, DbType.Int16);

                using (_serverHandler.Connection)
                {
                    userDetail = await _serverHandler.QuerySingleAsync<UserDetailDTO>("GetUserById", dynamicParameters);
                }
            }
            catch (Exception ex)
            {
            }
            return userDetail;
        }

        public async Task<int> SaveUserDetailsAsync(UserDetailDTO user)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@UserId", user.UserId, DbType.String);
                dynamicParameters.Add("@UserName", user.UserName, DbType.String);
                dynamicParameters.Add("@Password", user.Password, DbType.String);
                dynamicParameters.Add("@Email", user.Email, DbType.String);
                dynamicParameters.Add("@RegDate", user.RegDate, DbType.DateTime);
                dynamicParameters.Add("@Address", user.Address, DbType.String);
                dynamicParameters.Add("@DOB", user.DOB, DbType.DateTime);
                dynamicParameters.Add("@Gender", user.GenderId, DbType.Int16);
                dynamicParameters.Add("@MobileNo", user.MobileNo, DbType.Int32);
                dynamicParameters.Add("@Qualification", user.Qualification, DbType.String);
                dynamicParameters.Add("@Specialization", user.Specialization, DbType.String);
                dynamicParameters.Add("@YearId", user.YearId,DbType.Int32);
                dynamicParameters.Add("@BatchId", user.BatchId, DbType.Int32);
                dynamicParameters.Add("@RoleId", user.RoleId, DbType.Int32);


                response = await _serverHandler.ExecuteScalarAsync<int>("SaveUserInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }



    }

}
