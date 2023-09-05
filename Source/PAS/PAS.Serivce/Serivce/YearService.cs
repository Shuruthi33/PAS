using PAS.Model;
using PAS.Model.Input;
using PAS.Model.Output;
using PAS.Repository.Repository;
using PAS.Repository.Interface;
using PAS.Serivce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Serivce.Serivce
{
    public class YearService: IYearService
    {
        IYearRepository _yearRepository;
        public YearService(IYearRepository yearDetails)
        {
            _yearRepository = yearDetails;
        }

        public async Task<ResultDataArgs> DeleteYearDetailsByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _yearRepository.DeleteYearDetailsByIdAsync(Id);
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

        public async Task<ResultDataArgs> GetYearDetailsAsync()
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            YearDetailsResultDTO obj = await _yearRepository.GetYearDetailsAsync();
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.yearDetailsList;

            }
            else
            {
                resultArgs.StatusCode = 500;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultDataArgs> GetYearDetailsByIdAsync(int Id)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            YearDTO obj = await _yearRepository.GetYearDetailsByIdAsync(Id);
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

        public async Task<ResultDataArgs> SaveYearDetailsAsync(YearDTO year)
        {
            ResultDataArgs resultArgs = new ResultDataArgs();

            int result = await _yearRepository.SaveYearDetailsAsync(year);
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
