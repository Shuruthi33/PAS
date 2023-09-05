using PAS.Model;
using PAS.Model.Input;
using PAS.Model.Output;

using PAS.Repository.Interface;
using PAS.Serivce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Serivce
{
    public class BatchService : IBatchService
    {
        IBatchRepository    _batchRepository;

        public BatchService(IBatchRepository batchDetails)
        {
            _batchRepository = batchDetails;
        }

        public async Task<ResultDataArgs> DeleteBatchDetailsAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _batchRepository.DeleteBatchDetailsAsync(Id);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Deleted Successfully";

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultDataArgs> GetBatchDetailsAsync()
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            BatchDetailsResultDTO obj = await _batchRepository.GetBatchDetailsAsync();
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.batchDetailsList;

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultDataArgs> GetBatchDetailsByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();
            BatchDTO obj = await _batchRepository.GetBatchDetailsByIdAsync(Id);
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj;

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultDataArgs> SaveBatchDetailsAsync(BatchDTO batch)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _batchRepository.SaveBatchDetailsAsync(batch);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Save Successfully";
            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }
    }

       
  

      
    
}
