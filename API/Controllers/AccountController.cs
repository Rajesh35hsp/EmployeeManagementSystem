using Application;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {
            var result = await _accountService.CreateUserAsync(signUpModel);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest(result.Errors);
        }

        [HttpPost("signin")]
        public async Task<IActionResult> Login(SignInModel signinModel)
        {
            var result = await _accountService.LoginAsync(signinModel);
            if (!result.IsNullOrEmpty())
            {
                return Ok(result);
            }
            return Unauthorized();
        }
    }
}
