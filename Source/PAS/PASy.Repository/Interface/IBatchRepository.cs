using PAS.Model.Input;
using PAS.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Repository.Interface
{
    public interface IBatchRepository
    {
        Task<int> DeleteBatchDetailsAsync(int Id);
        Task<BatchDetailsResultDTO> GetBatchDetailsAsync();
        Task<BatchDTO> GetBatchDetailsByIdAsync(int Id);
        Task<int> SaveBatchDetailsAsync(BatchDTO batch);
    }
}
