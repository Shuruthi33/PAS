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
    public  class MentorRepository: IMentorRepository
    {
        ISQLServerHandler _serverHandler;

        public MentorRepository(ISQLServerHandler serverHandler)
        {
            _serverHandler = serverHandler;
        }

        public async Task<int> DeleteMentorByIdAsync(object Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@MentorId", Id, DbType.Int16);

                response = await _serverHandler.ExecuteScalarAsync<int>("DeleteMentorInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }


        public async Task<MentorDetailsResultDTO> GetMentorDetailsAsync()
        {
            MentorDetailsResultDTO mentorDetailResult = new MentorDetailsResultDTO();
            try
            {
                using (_serverHandler.Connection)
                {
                    mentorDetailResult.mentorDetailsList = (await _serverHandler.QueryAsync<MentorDTO>("GetMentorInfo")).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return mentorDetailResult;
        }

       

        public async Task<MentorDTO> GetMentorDetailsByIdAsync(object Id)
        {
            MentorDTO mentorDetail = new MentorDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@MentorId", Id, DbType.Int16);

                using (_serverHandler.Connection)
                {
                    mentorDetail = await _serverHandler.QuerySingleAsync<MentorDTO>("GetMentorById", dynamicParameters);
                }
            }
            catch (Exception ex)
            {
            }
            return mentorDetail;
        }

   
   

            public async Task<int> SaveMentorDetailsAsync(MentorDTO mentor)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@MentorId", mentor.MentorId, DbType.Int64);
                dynamicParameters.Add("@Name", mentor.Name, DbType.String);
                dynamicParameters.Add("@Email", mentor.Email, DbType.String);
                dynamicParameters.Add("@MobileNo", mentor.MobileNo, DbType.Int64);
                response = await _serverHandler.ExecuteScalarAsync<int>("SaveMentorInfo", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }
    }
}
