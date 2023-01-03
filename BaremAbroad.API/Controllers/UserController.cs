using BaremAbroad.Core.Services;
using BaremAbroad.Repository.DTOs.User;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //login control, create user, yeni blog, yeni yorum, getAllBlog(SP var raporda), getVommentsOfBlogArticle 
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetUserByIdAsync(int userId)
        {
            return Ok(await _userService.GetUserByIdAsync(userId));
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveUserByIdAsync(int userId)
        {
            await _userService.RemoveUserByIdAsync(userId);
            return Ok("User Removed Succesfully!");
        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateUserByIdAsync(UpdateUserDTO user)
        {
            return Ok(await _userService.UpdateUserByIdAsync(user));
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddUserAsync(CreateUserDTO user)
        {
            return Ok(await _userService.AddUserAsync(user));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }
    }
}
