using PAS.Model;
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
    public class LoginService : ILoginService
    {


        ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginDetails)
        {
            _loginRepository = loginDetails;
        }

        public async Task<ResultDataArgs> SaveLoginDetailsAsync(LoginDTO login)
        {
            ResultDataArgs resultArgs =  new ResultDataArgs();

            int result = await _loginRepository.SaveLoginDetailsAsync(login);
            if (result == 200)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Login Success";
            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Login Faild";
            }
            return resultArgs; 
        }
    }
}
