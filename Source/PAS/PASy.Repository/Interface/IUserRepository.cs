using PAS.Model.Input;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Interface
{
    public interface IUserRepository
    {
        Task<UserDetailsResultDTO> GetUserDetailsAsync();
        Task<UserDetailDTO> GetUserDetailsByIdAsync(int Id);
        Task<int> DeleteUserDetailsByIdAsync(int Id);
        Task<int> SaveUserDetailsAsync(UserDetailDTO user);
    }

}
