using PAS.Model.Input;
using PAS.Model;
using PAS.Model.Output;
using PAS.Repository.Implementation;
using PAS.Repository.Interface;
using PAS.Serivce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAS.Serce.Interface;

namespace PAS.Serivce.Implementation
{
    public class AuthenticateService : IAuthenticateService
    {
        IAuthenticateRepository _authenticateRepository;

        public AuthenticateService(IAuthenticateRepository authenticateRepository)
        {
            _authenticateRepository = authenticateRepository;
        }

        public async Task<ResultDataArgs?> GetLoginDetailsAsync(LoginDTO login)
        {
            ResultDataArgs resultArgs = new();

            int result = await _authenticateRepository.GetLoginDetailsAsync(login);
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

