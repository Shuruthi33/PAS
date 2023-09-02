using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAS.Model.Output;
using PAS.Serivce.Interface;

namespace PAS.API.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        public readonly IMentorService _mentorservice;

        public MentorController(IMentorService mentorDetailsService)
        {
            _mentorservice = mentorDetailsService;
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetMentorDetails")]
        public async Task<IActionResult> GetMentorDetilaAsync()
        {
            return Ok(await _mentorservice.GetMentorDetailsAsync());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetMentorDetailsByIdAsync")]
        public async Task<IActionResult> GetMentorDetailsByIdAsync(int id)
        {
            return Ok(await _mentorservice.GetMentorDetailsByIdAsync(id));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        [HttpPost]
        [ActionName("InsertMentortDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaveMentorDetailsAsync([FromBody] MentorDTO obj)
        {
            return Ok(await _mentorservice.SaveMentorDetailsAsync(obj));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        [HttpPut]
        [ActionName("UpdateMentortDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateMentorDetailsAsync([FromBody] MentorDTO obj)
        {
            return Ok(await _mentorservice.SaveMentorDetailsAsync(obj));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete]
        [ActionName("DeleteMentorDetailsByIdAsync")]
        public async Task<IActionResult> DeleteMentorByIdAsync(int id)
        {
            return Ok(await _mentorservice.DeleteMentorByIdAsync(id));
        }
    }
}
