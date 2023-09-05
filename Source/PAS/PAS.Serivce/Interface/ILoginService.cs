using PAS.Model.Output;
using PAS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Interface
{
    public interface ILoginService
    {
        Task<ResultDataArgs> SaveLoginDetailsAsync(LoginDTO login);
    }
}
