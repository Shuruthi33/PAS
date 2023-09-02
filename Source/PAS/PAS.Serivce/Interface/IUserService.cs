using PAS.Model;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Interface
{
    public interface IUserService
    {
        Task<ResultDataArgs> GetUserDetailsAsync();
        Task<ResultDataArgs> GetUserDetailsByIdAsync(int id);
        Task<ResultDataArgs> DeleteUserDetailsByIdAsync(int id);
        Task<ResultDataArgs> SaveUserDetailsAsync(UserDetailDTO user);
    }

}
