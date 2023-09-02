using PAS.Model.Input;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Interface
{
    public interface IMentorRepository
    {
       
        Task<int> DeleteMentorByIdAsync(object Id);
        Task<MentorDetailsResultDTO> GetMentorDetailsAsync();
        Task<MentorDTO> GetMentorDetailsByIdAsync(object Id);
        Task<int> SaveMentorDetailsAsync(MentorDTO mentor);
    }
}
