using PAS.Model.Input;
using PAS.Model.Output;
using PAS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAS.Repository.Interface;
using PAS.Serivce.Interface;
using static Octopus.Client.Model.TenantVariableResource;

namespace PAS.Serivce.Implementation
{
    public class MentorService: IMentorService
    {
        IMentorRepository _mentorRepository;

        public MentorService(IMentorRepository mentorDetails)
        {
            _mentorRepository = mentorDetails;
        }

        public async Task<ResultDataArgs> DeleteMentorByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _mentorRepository.DeleteMentorByIdAsync(Id);
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

        public async Task<ResultDataArgs> GetMentorDetailsAsync()
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            MentorDetailsResultDTO obj = await _mentorRepository.GetMentorDetailsAsync();
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.mentorDetailsList;

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;

        }

        public async Task<ResultDataArgs> GetMentorDetailsByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            MentorDTO obj = await _mentorRepository.GetMentorDetailsByIdAsync(Id);
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

        public async Task<ResultDataArgs> SaveMentorDetailsAsync(MentorDTO mentor)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _mentorRepository.SaveMentorDetailsAsync(mentor);
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
