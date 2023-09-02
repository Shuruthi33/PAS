using PAS.Model.Output;
using PAS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Interface
{
    public interface IMentorService
    {
        Task<ResultDataArgs> GetMentorDetailsAsync();
        Task<ResultDataArgs> GetMentorDetailsByIdAsync(int id);
        Task<ResultDataArgs> DeleteMentorByIdAsync(int id);
        Task<ResultDataArgs> SaveMentorDetailsAsync(MentorDTO mentor);
    }
}
