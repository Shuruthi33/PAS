using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAS.Model.Output;
using PAS.Serivce.Serivce;
using PAS.Serivce.Interface;

namespace PAS.API.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PrjAllotmentController : ControllerBase
    {
        public readonly IPrjAllotmentService _prjAllotmentService;

        public PrjAllotmentController(IPrjAllotmentService prjAllotmentDetails)
        {
            _prjAllotmentService = prjAllotmentDetails;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetPrjAllotemtDetails")]
        public async Task<IActionResult> GetPrjAllotmentDetailsAsync()
        {
            return Ok(await _prjAllotmentService.GetPrjAllotmentDetailsAsync());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetPrjAllotmentDetailsByIdAsync")]
        public async Task<IActionResult> GetPrjAllotmentDetailsByIdAsync(int Id)
        {
            return Ok(await _prjAllotmentService.GetPrjAllotmentDetailsByIdAsync(Id));
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="prjAllotment"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("InsertPrjAllotmentDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SavePrjAllotmentDetailsAsync([FromBody] PrjAllotmentDTO prjAllotment)
        {
            return Ok(await _prjAllotmentService.SavePrjAllotmentDetailsAsync(prjAllotment));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prjAllotment"></param>
        /// <returns></returns>

        [HttpPut]
        [ActionName("UpdatePrjAllotmentDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePrjAllotmentDetailsAsync([FromBody] PrjAllotmentDTO prjAllotment)
        {
            return Ok(await _prjAllotmentService.SavePrjAllotmentDetailsAsync(prjAllotment));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        [ActionName("DeletePrjAllotmentDetailsByIdAsync")]
        public async Task<IActionResult> DeletePrjAllotmentDetailsByIdAsync(int Id)
        {
            return Ok(await _prjAllotmentService.DeletePrjAllotmentDetailsByIdAsync(Id));
        }
    }
}
