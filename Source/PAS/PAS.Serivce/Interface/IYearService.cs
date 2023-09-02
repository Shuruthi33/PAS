using PAS.Model.Output;
using PAS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Interface
{
    public interface IYearService
    {
        Task<ResultDataArgs> GetYearDetailsAsync();
        Task<ResultDataArgs> GetYearDetailsByIdAsync(int Id);
        Task<ResultDataArgs> SaveYearDetailsAsync(YearDTO year);
        Task<ResultDataArgs> DeleteYearDetailsByIdAsync(int Id);
       
    }
}
