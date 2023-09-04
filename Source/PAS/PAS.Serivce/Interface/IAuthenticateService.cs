using PAS.Model;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serce.Interface
{
    public interface IAuthenticateService
    {
       
        Task<ResultDataArgs?> GetLoginDetailsAsync(LoginDTO login);
    }
}
