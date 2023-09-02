using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAS.Model.Output;
using PAS.Serivce.Interface;

namespace PAS.API.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
      public readonly  IProjectService _projectservice;

        public ProjectController(IProjectService projectDetailsService)
        {
            _projectservice = projectDetailsService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetProjectDetails")]
        public async Task<IActionResult> GetProjectAsync()
        {
            return Ok(await _projectservice.GetProjectAsync());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetProjectDetailsByIdAsync")]
        public async Task<IActionResult> GetProjectByIdAsync(int id)
        {
            return Ok(await _projectservice.GetProjectByIdAsync(id));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("InsertProjectDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaveProjectAsync([FromBody] ProjectDTO obj)
        {
            return Ok(await _projectservice.SaveProjectAsync(obj));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        [HttpPut]
        [ActionName("UpdateProjectDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProjectAsync([FromBody] ProjectDTO obj)
        {
            return Ok(await _projectservice.SaveProjectAsync(obj));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [ActionName("DeleteProjectDetailsByIdAsync")]
        public async Task<IActionResult> DeleteProjectAsync(int id)
        {
            return Ok(await _projectservice.DeleteProjectAsync(id));
        }
    }
}
