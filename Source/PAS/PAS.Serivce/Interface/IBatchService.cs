using PAS.Model.Output;
using PAS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Interface
{
    public interface IBatchService
    {
        Task<ResultDataArgs> GetBatchDetailsAsync();
        Task<ResultDataArgs> GetBatchDetailsByIdAsync(int Id);
        Task<ResultDataArgs> SaveBatchDetailsAsync(BatchDTO batch);
        Task<ResultDataArgs> DeleteBatchDetailsAsync(int Id);
    }
}
