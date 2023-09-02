using PAS.Model.Input;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Interface
{
    public interface IPrjAllotmentRepository
    {
        Task<PrjAllotmentDetailsResultDTO> GetPrjAllotmentDetailsAsync();
        Task<PrjAllotmentDTO> GetPrjAllotmentDetailsByIdAsync(int Id);
        Task<int> DeletePrjAllotmentDetailsByIdAsync(int Id);
        Task<int> SavePrjAllotmentDetailsAsync(PrjAllotmentDTO prjAllotment);
    }
}
