using PAS.Model.Output;
using PAS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Interface
{
    public interface IPrjAllotmentService
    {
        Task<ResultDataArgs> GetPrjAllotmentDetailsAsync();
        Task<ResultDataArgs> GetPrjAllotmentDetailsByIdAsync(int Id);
        Task<ResultDataArgs> DeletePrjAllotmentDetailsByIdAsync(int Id);
        Task<ResultDataArgs> SavePrjAllotmentDetailsAsync(PrjAllotmentDTO prjAllotment);
    }
}
