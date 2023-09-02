using PAS.Model;
using PAS.Model.Input;
using PAS.Model.Output;
using PAS.Repository.Implementation;
using PAS.Repository.Interface;
using PAS.Serivce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Octopus.Client.Model.TenantVariableResource;

namespace PAS.Serivce.Implementation
{
    public class PrjAllotmentService : IPrjAllotmentService
    {
        IPrjAllotmentRepository _prjAllomentRepository;

        public PrjAllotmentService (IPrjAllotmentRepository prjAllomentRepository)
        {
            _prjAllomentRepository = prjAllomentRepository;
        }

        public async Task<ResultDataArgs> DeletePrjAllotmentDetailsByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _prjAllomentRepository.DeletePrjAllotmentDetailsByIdAsync(Id);
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

        public async Task<ResultDataArgs> GetPrjAllotmentDetailsAsync()
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            PrjAllotmentDetailsResultDTO obj = await _prjAllomentRepository.GetPrjAllotmentDetailsAsync();
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.prjAllotmentDetailsList;

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultDataArgs> GetPrjAllotmentDetailsByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            PrjAllotmentDTO obj = await _prjAllomentRepository.GetPrjAllotmentDetailsByIdAsync(Id);
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

        public async Task<ResultDataArgs> SavePrjAllotmentDetailsAsync(PrjAllotmentDTO prjAllotment)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _prjAllomentRepository.SavePrjAllotmentDetailsAsync(prjAllotment);
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
