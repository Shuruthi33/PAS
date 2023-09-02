using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PAS.Model;
using PAS.Model.Output;
using PAS.Serivce.Implementation;
using PAS.Serivce.Interface;
using PMT.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PAS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthenticationController : ControllerBase
    {
        public readonly IAuthenticateService _authenticateService;

        public UserAuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
            
        }

        //[HttpPost]
        //[ActionName("GetYearDetails")]
        //public async Task<IActionResult> GetLoginDetailsAsync()
        //{
        //    return Ok(await _authenticateService.GetLoginDetailsAsync());
        //}
    }
}
