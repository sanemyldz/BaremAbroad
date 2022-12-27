using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPasswordController : Controller
    {
        private readonly IUserPasswordService _userPasswordService;

        public UserPasswordController(IUserPasswordService userPasswordService)
        {
            _userPasswordService = userPasswordService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUserPasswordByIdAsync(int userId)
        {
            return Ok(await _userPasswordService.GetUserPasswordByIdAsync(userId));
        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateUserPasswordAsync(UserPassword userPassword)
        {
            await _userPasswordService.UpdateUserPasswordAsync(userPassword);
            return NoContent();
        }

    }
}
