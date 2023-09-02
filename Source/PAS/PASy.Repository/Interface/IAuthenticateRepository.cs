using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Interface
{
    public interface IAuthenticateRepository
    {
        Task<int> GetLoginDetailsAsync(LoginDTO login);
    }
}
