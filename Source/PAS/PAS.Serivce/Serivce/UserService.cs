using PAS.Model;
using PAS.Model.Input;
using PAS.Model.Output;
using PAS.Repository.Repository;
using PAS.Repository.Interface;
using PAS.Serivce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Serivce

{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;

        public UserService(IUserRepository userDetails)
        {
            _userRepository = userDetails;
        }

        public async Task<ResultDataArgs> DeleteUserDetailsByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _userRepository.DeleteUserDetailsByIdAsync(Id);
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
        public async Task<ResultDataArgs> GetUserDetailsAsync()
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            UserDetailsResultDTO obj = await _userRepository.GetUserDetailsAsync();
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.userDetailList;

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultDataArgs> GetUserDetailsByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            UserDetailDTO obj = await _userRepository.GetUserDetailsByIdAsync(Id);
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

        public async Task<ResultDataArgs> SaveUserDetailsAsync(UserDetailDTO user)
        {

            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _userRepository.SaveUserDetailsAsync(user);
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