using Microsoft.AspNetCore.Mvc;
using PAS.Model.Output;
using PAS.Serivce.Interface;

namespace PAS.API.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   
    public class UserController : ControllerBase
    {
        public readonly IUserService _userDetailsService;

        public UserController(IUserService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetUserDetails")]
        public async Task<IActionResult> GetUserDetailsAsync()
        {
            return Ok(await _userDetailsService.GetUserDetailsAsync());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]
        [ActionName("GetUserDetailsByIdAsync")]
        public async Task<IActionResult> GetUserDetailsByIdAsync(int id)
        {
            return Ok(await _userDetailsService.GetUserDetailsByIdAsync(id));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        [HttpPost]
        [ActionName("InsertUserDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaveUserDetailsAsync([FromBody] UserDetailDTO obj)
        {
            return Ok(await _userDetailsService.SaveUserDetailsAsync(obj));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ActionName("UpdateUserDetailsAsync")]
        public async Task<IActionResult> UpdateUserDetailsAsync(int id, [FromBody] UserDetailDTO obj)
        {
            obj.UserId = id;
            return Ok(await _userDetailsService.SaveUserDetailsAsync(obj));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete]
        [ActionName("DeleteUserDetailsByIdAsync")]
        public async Task<IActionResult> DeleteUserDetailsByIdAsync(int id)
        {
            return Ok(await _userDetailsService.DeleteUserDetailsByIdAsync(id));
        }

    }
}
