using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAS.Model.Output;
using PAS.Serivce.Interface;

namespace PAS.API.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        public readonly ILoginService _loginService;

        public LoginController(ILoginService loginDetailsService)
        {
            _loginService = loginDetailsService;
        } 
        [HttpPost]
        [ActionName("SaveLoginDetails")]
        public async Task<IActionResult> SaveLoginDetailsAsync([FromBody] LoginDTO login)
        {
            return Ok(await _loginService.SaveLoginDetailsAsync(login));
        }
    }
}
