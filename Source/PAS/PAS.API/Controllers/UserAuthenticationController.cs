using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PAS.Model;
using PAS.Model.Output;
using PAS.Serce.Interface;
using PAS.Serivce.Implementation;
using PAS.Serivce.Interface;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PAS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthenticationController : ControllerBase
    {
        IAuthenticateService _authenticateService;
        public readonly IWebHostEnvironment _webHostEnvironment;

        public UserAuthenticationController(IAuthenticateService authenticateService, IWebHostEnvironment webHostEnvironment)
        {
            _authenticateService = authenticateService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        [ActionName("GetLoginDetails")]
        public async Task<IActionResult> GetLoginDetailsAsync([FromBody] LoginDTO login)
        {
            return Ok(await _authenticateService.GetLoginDetailsAsync(login));
        }

    }
}
