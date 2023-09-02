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

namespace PAS.Serivce.Implementation
{
    public class AuthenticateService : IAuthenticateService
    {
        IAuthenticateRepository _authenticateRepository;

        public AuthenticateService(IAuthenticateRepository authenticateRepository)
        {
            _authenticateRepository = authenticateRepository;
        }

       
    }
}

