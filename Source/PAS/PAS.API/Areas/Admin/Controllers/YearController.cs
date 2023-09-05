using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAS.Model.Output;
using PAS.Serivce.Serivce;
using PAS.Serivce.Interface;

namespace PAS.API.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class YearController : ControllerBase
    {
       
      public readonly IYearService _yearService;

        public YearController(IYearService yearDetailsService)
        {
            _yearService = yearDetailsService;
        }

        [HttpGet]
        [ActionName("GetYearDetails")]
        public async Task<IActionResult> GetYearDetailsAsync()
        {
            return Ok(await _yearService.GetYearDetailsAsync());
        }

       
        [HttpGet]
        [ActionName("GetYearDetailsByIdAsync")]
        public async Task<IActionResult> GetYearDetailsByIdAsync(int Id)
        {
            return Ok(await _yearService.GetYearDetailsByIdAsync(Id));
        }

        [HttpPost]
        [ActionName("InsertYearDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaveYearDetailsAsync([FromBody] YearDTO year)
        {
            return Ok(await _yearService.SaveYearDetailsAsync(year));
        }

        [HttpPost]
        [ActionName("UpdateYearDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateYearDetailsAsync([FromBody] YearDTO year)
        {
            return Ok(await _yearService.SaveYearDetailsAsync(year));
        }

        [HttpDelete]
        [ActionName("DeleteUserDetailsByIdAsync")]
        public async Task<IActionResult> DeleteYearDetailsByIdAsync(int Id)
        {
            return Ok(await _yearService.DeleteYearDetailsByIdAsync(Id));
        }




    }
}

