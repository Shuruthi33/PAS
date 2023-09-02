using PAS.Model.Input;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Interface
{
    public interface IYearRepository
    {
        Task<YearDetailsResultDTO> GetYearDetailsAsync();
        Task<YearDTO> GetYearDetailsByIdAsync(int Id);
        Task<int> DeleteYearDetailsByIdAsync(int Id);
        Task<int> SaveYearDetailsAsync(YearDTO year);
    }
}
