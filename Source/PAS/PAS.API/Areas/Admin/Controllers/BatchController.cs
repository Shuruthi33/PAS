using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAS.Model.Output;
using PAS.Serivce.Serivce;
using PAS.Serivce.Interface;

namespace PAS.API.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        public readonly IBatchService _batchService;

        public BatchController(IBatchService batchDetailsService)
        {
            _batchService = batchDetailsService;     
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetBatchDetails")]
        public async Task<IActionResult> GetBatchDetailsAsync()
        {
            return Ok(await _batchService.GetBatchDetailsAsync());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetBatchDetailsByIdAsync")]
        public async Task<IActionResult> GetBatchDetailsByIdAsync(int Id)
        {
            return Ok(await _batchService.GetBatchDetailsByIdAsync(Id));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        [HttpPost]
        [ActionName("InsertBatchtDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaveBatchDetailsAsync([FromBody] BatchDTO obj)
        {
            return Ok(await _batchService.SaveBatchDetailsAsync(obj));
        }

        [HttpPut]
        [ActionName("UpdateBatchtDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateBatchDetailsAsync([FromBody] BatchDTO obj)
        {
            return Ok(await _batchService.SaveBatchDetailsAsync(obj));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        [HttpDelete]
        [ActionName("DeleteMentorDetailsByIdAsync")]
        public async Task<IActionResult> DeleteBatchDetailsAsync(int Id)
        {
            return Ok(await _batchService.DeleteBatchDetailsAsync(Id));
        }
    }
}
